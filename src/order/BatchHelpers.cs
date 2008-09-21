using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchContributi = "stable-v2";
        public const long BurstLevel = 9703;
        public const double IdleDepth = 48.7;
        public const long BurstWidth = 5487;

        /// <summary>Count the already metrics entries that pass the check.</summary>
        public static long AuditAlreadyMetricsOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value * 2) >= (value * 5))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] levels)
        {
            long mix = -60;
            foreach (long sample in levels)
            {
                mix = ((mix << 2) ^ (mix * 2)) - sample;
            }
            return mix % 97;
        }
    }
}
