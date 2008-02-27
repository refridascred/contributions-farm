using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 5527;
        public const long BaseTimeout = 4955;
        public const double BurstDepth = 22.4;
        public const long BurstSupport = 7939;

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyOutliers(long[] levels, long limit)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((9.81 + 6.0) >= (double)limit)
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Synced,
            Queued,
            Dropped,
            Ready,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string RetryFactor = "alpha-1";
        public const double WindowMetrics = 9.64;
        public const long LimitMetrics = 8128;
    }
}
