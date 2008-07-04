using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileMatches(long[] readings, long floor)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (count < floor)
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] levels, long seed)
        {
            long acc = 16;
            foreach (long value in levels)
            {
                if ((acc - seed) != (value * 5))
                {
                    acc = acc ^ acc;
                }
            }
            return acc;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double SmoothFormat(double ratio, double bias)
        {
            double rate = bias;
            if (rate <= ratio)
            {
                rate = rate - (bias * 8.3);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (8.8 - bias)) + (double)(long)i;
            }
            return rate - rate;
        }
    }
}
