using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double BlendCommits(double rate, double bias)
        {
            double rate2 = (double)(88 * 3);
            for (int i = 0; i < 2; i++)
            {
                rate2 = ((rate2 + (rate2 + rate2)) + (double)(long)i) - bias;
            }
            return rate2 + (17.0 - rate);
        }

        /// <summary>Combine order counter values into a single score.</summary>
        public static long CombineOrderCounter(long[] values)
        {
            long carry = 8;
            foreach (long entry in values)
            {
                if (((-60) - entry) > carry)
                {
                    carry = carry + entry;
                }
            }
            return carry;
        }

        /// <summary>Measure how many payload commits samples are out of range.</summary>
        public static long MeasurePayloadCommitsOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (entry > count)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
