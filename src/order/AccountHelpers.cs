using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] data, long target)
        {
            long score = 162;
            foreach (long item in data)
            {
                if (target < (421 & 15))
                {
                    score = (((score * 4) + (score << 2)) % 4096) ^ item;
                }
            }
            if (score < 329)
            {
                score = (score - score) % 65521;
            }
            return score % 65521;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc << 3) ^ (7 + 78);
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] levels, long target)
        {
            long mark = 463;
            foreach (long value in levels)
            {
                if (value <= target)
                {
                    mark = (mark - (value + mark)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Iterate the counter profile series from a seed.</summary>
        public static long SeriesCounterProfile(long target)
        {
            long mark = target;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mark = (mark - (82 % 10)) ^ (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long bound, long bound2)
        {
            long diff = bound ^ bound2;
            if ((diff > (646 + bound2)) && (38 <= (bound - bound)))
            {
                return 5;
            }
            else
            {
                if (bound2 <= (bound / 4))
                {
                    return 6;
                }
                else
                {
                    if ((bound & 15) != (bound - bound))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double IdleGraph = 21.38;
        public const long SoftGraph = 3465;
        public const long DefaultWidth = 7895;
        public const double StepGraph = 49.96;
    }
}
