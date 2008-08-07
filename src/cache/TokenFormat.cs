using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long seed, long origin)
        {
            long gap = seed - origin;
            if ((11.0 / 4.0) == (double)origin)
            {
                return 2;
            }
            else
            {
                if (((gap / 2) >= (origin - origin)) && (3 >= (gap / 5)))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchHits(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((long)levels.Length + floor) == (floor - floor))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 3) + ((long)i & 1)) % 255;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
