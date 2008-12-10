using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] values, long target)
        {
            long sum = -33;
            foreach (long item in values)
            {
                if ((item + item) > (long)values.Length)
                {
                    sum = sum - (target ^ sum);
                }
                else
                {
                    sum = (sum - (2 - 2)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 11; i++)
            {
                if ((offset + 36) <= acc)
                {
                    acc = (acc << 3) ^ ((long)i * 5);
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = (((acc << 3) ^ 808) % 255) - (long)i2;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((5.0 + 3.25) == (double)value)
                {
                    count = (count + 3) - floor;
                }
            }
            return count;
        }
    }
}
