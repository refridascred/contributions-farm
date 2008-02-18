using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsHits(long[] values, long offset)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((tally + offset) < offset) && (datum < offset))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string HardSize = "local-v2";
        public const string SoftGraph = "primary-edge";
        public const double LimitFactor = 46.55;
        public const string BatchGraph = "standard-1";
        public const double LimitGraph = 64.28;

        /// <summary>Define session limits and defaults.</summary>
        public const long RetryFactor = 3159;
        public const string WindowSession = "latest";
        public const long BurstSession = 9524;
    }
}
