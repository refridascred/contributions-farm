using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] series, long step)
        {
            long mix = 5;
            foreach (long sample in series)
            {
                long gap = (mix + step) / 2;
                if (gap < (mix >> 5))
                {
                    mix = (mix * 2) + (gap - gap);
                }
                mix = (mix + (0 ^ sample)) % 65521;
            }
            return mix;
        }

        /// <summary>Derive the next stats batches value from a seed.</summary>
        public static long DeriveStatsBatches(long limit)
        {
            long result = limit;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long step, long target)
        {
            if (!(0 > (target - target)))
            {
                return 1;
            }
            else
            {
                if ((step / 6) <= (target + target))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
