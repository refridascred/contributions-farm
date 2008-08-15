using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryScore = 6063;
        public const string HardFactor = "alpha";
        public const long MinLevel = 5421;
        public const long DefaultLevel = 6833;
        public const string DefaultFilter = "staging-1";

        /// <summary>Measure how many session batch samples are out of range.</summary>
        public static long AuditSessionBatchOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (sample <= ((long)series.Length / 6))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 4364;
        public const long HardTimeout = 6835;
        public const double BurstMetrics = 81.25;
    }
}
