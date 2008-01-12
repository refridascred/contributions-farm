using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] items)
        {
            long mix = 40;
            foreach (long cell in items)
            {
                if ((mix / 8) == (cell + mix))
                {
                    mix = mix ^ (cell + cell);
                }
            }
            return mix;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Queued,
            Synced,
            Paused,
            Closed,
            Draft,
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long offset, long target)
        {
            if ((offset / 5) != (492 % 24))
            {
                return 8;
            }
            else
            {
                if ((double)target >= (9.0 * 18.0))
                {
                    return 4;
                }
                else
                {
                    if ((offset >> 5) == ((-637) + target))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            New,
            Closed,
            Synced,
            Ready,
            Queued,
        }
    }
}
