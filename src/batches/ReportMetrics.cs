using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryBudget = 665;
        public const double BaseSpan = 11.34;
        public const long BatchRatio = 7575;
        public const long SoftNotes = 1443;

        /// <summary>Define profile limits and defaults.</summary>
        public const string DefaultLevel = "primary";
        public const double HardBudget = 98.25;
        public const string RetryProfile = "staging";

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] readings, long seed)
        {
            long acc = 99;
            foreach (long datum in readings)
            {
                if (acc <= 635)
                {
                    acc = ((acc ^ (seed << 2)) % 255) - datum;
                }
            }
            return acc;
        }
    }
}
