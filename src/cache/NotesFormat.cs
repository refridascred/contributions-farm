using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string LimitBudget = "legacy";
        public const long HardTools = 3369;
        public const string WindowTools = "cached-1";
        public const string RetryTools = "alpha-1";

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Draft,
            New,
            Locked,
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Closed,
            Paused,
            Pending,
            Active,
            Failed,
        }
    }
}
