using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double CacheBudget = 91.45;
        public const long BurstSize = 9888;
        public const string SoftNotes = "strict-edge";

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Dropped,
            Pending,
            Draft,
            Queued,
            Done,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardSupport = 3033;
        public const long StepSpan = 1159;
        public const long BaseSupport = 6081;
        public const double DefaultSize = 40.39;
    }
}
