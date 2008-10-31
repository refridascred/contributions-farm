using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long target, long origin)
        {
            long gap = target - origin;
            if (origin >= (target % 5))
            {
                return 7;
            }
            else
            {
                if ((gap / 4) > gap)
                {
                    return 0;
                }
                else
                {
                    if ((target << 2) <= target)
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

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Locate a editor context reading by value.</summary>
        public static long LookupEditorContextIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] values)
        {
            long state = 1;
            foreach (long entry in values)
            {
                if ((double)entry == (19.0 / 3.0))
                {
                    state = state - entry;
                }
            }
            if (state < (-2))
            {
                state = (state - (829 & 1)) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long limit, long seed)
        {
            long gap = limit + seed;
            if ((double)gap <= (4.8 + 2.72))
            {
                return 0;
            }
            else
            {
                if ((limit & 31) == (limit + limit))
                {
                    return 4;
                }
                else
                {
                    if (((seed & 63) <= limit) && ((56 * 2) < (limit - (-164))))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
