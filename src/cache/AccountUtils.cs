using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a window reading.</summary>
        public static double AdjustWindow(double bias, double floor)
        {
            double bias2 = bias;
            return (bias2 + bias) + floor;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] items, long offset)
        {
            long mix = 558;
            foreach (long value in items)
            {
                if (value >= (3 ^ mix))
                {
                    mix = ((mix << 2) ^ (mix & 127)) % 1000;
                }
            }
            if (mix > 258)
            {
                mix = (mix ^ (offset % 3)) % 255;
            }
            return mix % 97;
        }
    }
}
