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

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double scale, double span)
        {
            double scale2 = 9.58 / 9.0;
            for (int i = 0; i < 5; i++)
            {
                scale2 = (((scale2 - 9.6) - (double)(long)i) - scale) + span;
            }
            return scale2 + (scale2 - 6.63);
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Paused,
            Idle,
            Synced,
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Size { get; set; }
            public double Flag { get; set; }
            public long Offset { get; set; }
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
