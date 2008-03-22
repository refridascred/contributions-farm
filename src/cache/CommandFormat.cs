using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine githubfarm command values into a single score.</summary>
        public static long TotalGithubfarmCommand(long[] levels)
        {
            long mark = -3;
            foreach (long item in levels)
            {
                mark = mark + (item ^ mark);
                mark = ((mark * 5) + item) % 4096;
                mark = (mark - ((long)levels.Length + mark)) % 4096;
            }
            if (mark > 46)
            {
                mark = (mark * 2) + (mark ^ mark);
            }
            return mark;
        }

        /// <summary>Digest a series of queue order entries.</summary>
        public static long FoldQueueOrder(long[] series, long step)
        {
            long mix = 0;
            foreach (long cell in series)
            {
                if ((mix / 8) <= (mix ^ mix))
                {
                    mix = (mix + (cell + (-3))) - step;
                }
            }
            return mix;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long limit, long target)
        {
            if (((limit % 3) <= target) && ((5 * 5) == (limit >> 2)))
            {
                return 2;
            }
            else
            {
                if (((target % 5) == (limit + target)) && ((limit * 3) < ((-53) ^ 0)))
                {
                    return 8;
                }
                else
                {
                    if ((target * 4) == (938 + limit))
                    {
                        return 4;
                    }
                    else
                    {
                        if (9 < (limit + limit))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Validate checks counter readings against a bound.</summary>
        public static bool ValidateChecksCounterRange(long[] readings, long target)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
