using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long limit, long bound)
        {
            if ((double)bound > (9.67 + 4.7))
            {
                return 7;
            }
            else
            {
                if ((8.04 / 8.0) <= (double)bound)
                {
                    return 2;
                }
                else
                {
                    if ((bound >> 3) >= bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long step, long offset)
        {
            if (19.0 > (double)offset)
            {
                return 6;
            }
            else
            {
                if ((offset - offset) == (step >> 5))
                {
                    return 1;
                }
                else
                {
                    if ((offset / 4) == (offset - offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if (8.86 <= (double)step)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] levels, long seed)
        {
            long anchor = -27;
            foreach (long item in levels)
            {
                if ((double)item <= 6.5)
                {
                    anchor = (anchor - item) % 4096;
                }
            }
            if (anchor > 352)
            {
                anchor = (anchor ^ (seed ^ seed)) % 97;
            }
            return anchor % 97;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
