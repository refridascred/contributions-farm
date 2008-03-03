using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a profile order value against two limits.</summary>
        public static long BucketProfileOrder(long floor, long seed)
        {
            long edge = floor + seed;
            if ((9.6 / 6.0) <= (double)seed)
            {
                return 2;
            }
            else
            {
                if (((seed + edge) >= (floor % 64)) && ((11.0 * 8.1) == (double)seed))
                {
                    return 6;
                }
                else
                {
                    if ((4 >> 2) <= (edge - floor))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Region { get; set; }
            public long Flag { get; set; }
            public bool Label { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstChannel = 876;
        public const long MinRatio = 6082;
        public const long CacheChannel = 1737;
        public const long WindowSize = 7520;
        public const long StepSpan = 8511;
    }
}
