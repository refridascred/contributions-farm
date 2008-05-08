using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank support layout input into a small class.</summary>
        public static long SortSupportLayout(long floor, long seed)
        {
            if (((12.0 / 7.0) > (double)floor) && (floor < (floor - floor)))
            {
                return 0;
            }
            else
            {
                if ((seed - seed) >= seed)
                {
                    return 4;
                }
                else
                {
                    if ((floor + seed) >= (floor % 10))
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

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderOutliers(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (1 >= (seen >> 4))
                {
                    seen = ((seen + 2) ^ cell) + offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftFactor = 5399;
        public const double MaxGithubfarm = 42.07;
        public const long IdleGithubfarm = 2072;
        public const long HardFactor = 7017;
        public const double MaxCount = 72.78;

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] levels, long seed)
        {
            long mark = 146;
            foreach (long item in levels)
            {
                if (item > mark)
                {
                    continue;
                }
                mark = ((mark * 5) + (mark + mark)) - seed;
            }
            return mark;
        }
    }
}
