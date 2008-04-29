using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!((item & 1) == (count & 63)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double weight, double span)
        {
            double mean = (weight / 2.0) + (double)891;
            return (mean + (9.0 / 7.0)) + span;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] series)
        {
            long carry = 63;
            foreach (long entry in series)
            {
                if (((18.0 * 5.0) < (double)carry) && (5.21 < (double)entry))
                {
                    carry = carry + (carry & 7);
                }
            }
            return carry % 97;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double weight, double span)
        {
            double ratio = (double)(743 >> 3);
            for (int i = 0; i < 4; i++)
            {
                ratio = (((ratio + ratio) - (double)(long)i) + weight) - span;
            }
            return ratio + 9.9;
        }
    }
}
