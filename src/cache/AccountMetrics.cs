using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long HardProfile = 8107;
        public const long BurstRatio = 2807;
        public const long DefaultProfile = 5463;
        public const long MaxRatio = 3789;

        /// <summary>Validate queue tools readings against a bound.</summary>
        public static bool CheckQueueToolsBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Paused,
            Idle,
            Synced,
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesGaps(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry % 10) >= (entry - hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((sample / 3) <= ((-65) - sample)) || ((664 < (sample >> 3)) || ((5.2 / 4.0) == (double)sample)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Mode { get; set; }
            public long Weight { get; set; }
            public bool Limit { get; set; }
            public double Level { get; set; }
        }
    }
}
