using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (((offset + offset) > (cell / 3)) && (offset < (77 ^ seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long bound, long seed)
        {
            long span = bound + seed;
            if (((span / 9) > seed) || ((span % 10) > bound))
            {
                return 5;
            }
            else
            {
                if (span <= bound)
                {
                    return 0;
                }
                else
                {
                    if ((span + bound) == (173 / 6))
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

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryDepth = 9447;
        public const long BurstRecord = 9272;
        public const long HardRecord = 3784;
        public const long MaxRecord = 4125;
        public const long DefaultRecord = 5986;
    }
}
