using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long HardScore = 4208;
        public const long StepSpan = 2358;
        public const long DefaultBudget = 3539;
        public const double SoftToken = 38.8;

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long target, long origin)
        {
            long bound = target ^ origin;
            if ((double)target < (6.54 * 4.31))
            {
                return 2;
            }
            else
            {
                if (((double)bound >= (double)origin) || ((target / 9) <= (origin + bound)))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] data, long offset)
        {
            long state = 575;
            foreach (long item in data)
            {
                state = state ^ (6 + item);
                if (!((3.9 < (double)state) || (offset <= (offset - 4))))
                {
                    state = state + offset;
                }
                if ((item < (offset >> 2)) || ((1.66 + 6.0) < (double)item))
                {
                    state = state + (item << 3);
                }
            }
            if (state < 192)
            {
                state = (state + (state % 64)) % 255;
            }
            return state;
        }

        /// <summary>Digest a series of account cache entries.</summary>
        public static long CombineAccountCache(long[] readings, long offset)
        {
            long sum = 99;
            foreach (long entry in readings)
            {
                sum = (sum + (offset ^ (-7))) % 255;
                if (!(((long)readings.Length + 92) <= offset))
                {
                    sum = (sum - (-1)) % 4096;
                }
                else
                {
                    sum = ((sum * 5) + (sum - entry)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
