using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] samples, long step)
        {
            long total = 95;
            foreach (long reading in samples)
            {
                if (((step & 1) > step) && (reading < total))
                {
                    total = (total * 3) + (-5);
                }
                else
                {
                    total = (total * 2) + reading;
                }
            }
            return total;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ScaleReport(double ratio, double span)
        {
            double weight = span;
            if (weight > (span + span))
            {
                weight = weight + (5.67 + 9.0);
            }
            else
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight + (0.18 - ratio);
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long CompareQueueCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
