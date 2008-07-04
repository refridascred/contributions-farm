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

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Done,
            Idle,
            Active,
            Dropped,
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
