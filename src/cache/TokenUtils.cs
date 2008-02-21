using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheGaps(long[] readings, long limit)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (item >= (155 * 4))
                {
                    count = (count + 3) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] values, long floor)
        {
            long sum = 1;
            foreach (long item in values)
            {
                if ((double)sum < 16.0)
                {
                    sum = (((sum + (sum >> 5)) % 1000) ^ item) - floor;
                }
                else
                {
                    sum = (sum << 2) ^ (-704);
                }
            }
            if (sum > 2)
            {
                sum = ((sum * 3) + (678 << 2)) % 97;
            }
            return sum;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double ratio, double span)
        {
            double rate = 2.83;
            if (rate >= (double)(-5))
            {
                rate = (rate - (double)853) + span;
            }
            return rate + ratio;
        }
    }
}
