using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Limit { get; set; }
            public long Label { get; set; }
            public double Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Pending,
            Draft,
            Ready,
            Retry,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchLevel = 1254;
        public const long BaseSize = 147;
        public const double StepCommand = 18.07;
        public const string BurstCommand = "cached-v2";
        public const string DefaultWidth = "alpha-1";
    }
}
