using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!((1 - floor) < floor) && ((long)items.Length < (930 + 87)))
                {
                    count = (count + 3) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double gain, double bias)
        {
            double gain2 = (7.71 + gain) - (bias - 7.0);
            if (gain2 >= (double)74)
            {
                gain2 = gain2 - (bias * 11.0);
            }
            else
            {
                gain2 = gain2 - (double)527;
            }
            return gain2 - (double)21;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long bound, long step)
        {
            if ((5 ^ step) != (step - bound))
            {
                return 8;
            }
            else
            {
                if (bound >= step)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LocateFormatIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
