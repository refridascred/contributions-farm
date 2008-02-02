using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long CacheRatio = 2567;
        public const long DefaultContext = 2129;
        public const string RetryContext = "stable-1";

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Level { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Scale a notes cluster figure with a bias.</summary>
        public static double SmoothNotesCluster(double gain, double floor)
        {
            double rate = floor + floor;
            if (rate > gain)
            {
                rate = rate + (double)0;
            }
            return rate - 16.0;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading + reading) == (reading + hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the batches metrics entries that pass the check.</summary>
        public static long AuditBatchesMetricsOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (7.0 < (double)sample)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
