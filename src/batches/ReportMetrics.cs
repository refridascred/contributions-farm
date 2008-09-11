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

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheGaps(long[] data, long limit)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((double)sample <= (14.0 * 9.1))
                {
                    tally = (tally + 3) - limit;
                }
            }
            return tally;
        }
    }
}
