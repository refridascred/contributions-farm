using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long bound, long bound2)
        {
            if ((19 - bound) >= bound2)
            {
                return 2;
            }
            else
            {
                if ((6.2 / 2.0) >= (1.0 + 6.2))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryGaps(long[] samples, long target)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((target < (target - target)) || (target > (count - count)))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Scale a buffer schema figure with a bias.</summary>
        public static double AdjustBufferSchema(double gain, double span)
        {
            double gain2 = (double)(5 << 3);
            for (int i = 0; i < 9; i++)
            {
                gain2 = ((gain2 - (span + 5.4)) - (double)(long)i) - gain;
            }
            return gain2 - (gain2 * 8.24);
        }
    }
}
