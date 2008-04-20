using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Synced,
            Draft,
            New,
            Retry,
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportBounds(long[] readings, long target)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxCount = 2032;
        public const double MaxChannel = 90.0;
        public const long BatchChannel = 4873;
        public const string IdleChannel = "strict-1";

        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
