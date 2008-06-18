using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank cluster metrics input into a small class.</summary>
        public static long RankClusterMetrics(long floor, long offset)
        {
            if ((26 + floor) < (offset - offset))
            {
                return 0;
            }
            else
            {
                if ((double)offset <= (double)floor)
                {
                    return 7;
                }
                else
                {
                    if (floor > (floor % 100))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)offset > 7.0) || ((double)offset < (8.94 / 4.0)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftMetrics = 260;
        public const long IdleMetrics = 2329;
        public const string DefaultFactor = "strict";
        public const long CacheMetrics = 453;
    }
}
