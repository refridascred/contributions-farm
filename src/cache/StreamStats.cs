using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsOutliers(long[] series, long step)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((double)reading >= (6.95 + 5.36))
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Synced,
            Pending,
            Dropped,
            Paused,
            Draft,
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((5.31 - 6.0) == (double)hits)
                {
                    hits = (hits + 1) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BaseFactor = "standard-edge";
        public const long HardSize = 8925;
        public const string BurstChecks = "open-v2";
    }
}
