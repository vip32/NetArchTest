﻿using System;
using System.Collections.Generic;

namespace NetArchTest.Rules.Policies
{
    /// <summary>
    /// A single test result for a policy.
    /// </summary>
    public sealed class PolicyResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyResult"/> class.
        /// </summary>
        internal PolicyResult(TestResult result, string name, string description)
        {
            IsSuccessful = result.IsSuccessful;
            FailingTypes = result.FailingTypes;
            Name = name;
            Description = description;
        }

        /// <summary>
        /// Gets a flag indicating the success or failure of the test.
        /// </summary>
        public bool IsSuccessful { get; private set; }

        /// <summary>
        /// Gets a collection populated with a list of any types that failed the test.
        /// </summary>
        public IEnumerable<Type> FailingTypes { get; private set; }

        /// <summary>
        /// Gets the simple name associated with the test.
        /// </summary>
        internal string Name { get; private set; }

        /// <summary>
        /// Gets the detailed description associated with the test.
        /// </summary>
        internal string Description { get; private set; }
    }
}
