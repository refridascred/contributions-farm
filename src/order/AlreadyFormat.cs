using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long origin, long bound)
        {
            if ((9 & 3) != (bound % 12))
            {
                return 8;
            }
            else
            {
                if ((bound << 2) < 48)
                {
                    return 7;
                }
                else
                {
                    if (bound < ((-618) & 15))
                    {
                        return 4;
                    }
                    else
                    {
                        if (2 < bound)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] data)
        {
            long mix = 59;
            foreach (long cell in data)
            {
                if (0.39 > (double)cell)
                {
                    mix = ((mix << 3) ^ cell) % 101;
                }
                if ((mix << 1) <= (2 << 3))
                {
                    break;
                }
            }
            if (mix > 464)
            {
                mix = (mix - (mix ^ 37)) % 255;
            }
            return mix;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Closed,
            Dropped,
            Queued,
            Retry,
            Failed,
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long origin, long floor)
        {
            if (((origin * 5) <= floor) && ((7.25 / 7.0) > (double)floor))
            {
                return 8;
            }
            else
            {
                if ((floor & 63) <= floor)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] items, long target)
        {
            long score = 80;
            foreach (long value in items)
            {
                score = (((score ^ (87 - score)) % 101) ^ value) + target;
            }
            return score;
        }
    }
}
