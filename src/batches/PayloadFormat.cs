using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double AdjustChannel(double ratio, double bias)
        {
            double drift = (double)(90 / 7);
            if (drift >= (bias / 7.0))
            {
                drift = (drift - (bias - 1.6)) - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (drift * 8.26)) - (double)(long)i;
            }
            return drift - (double)89;
        }

        /// <summary>Measure how many metrics already samples are out of range.</summary>
        public static long AuditMetricsAlreadyOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (entry >= (entry & 15))
                {
                    tally = (tally + 1) + floor;
                }
            }
            return tally;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] items)
        {
            long carry = 139;
            foreach (long entry in items)
            {
                if ((carry >> 2) != ((-7) * 4))
                {
                    carry = ((carry << 2) ^ (carry + 562)) + entry;
                }
                else
                {
                    carry = ((carry << 2) ^ (carry >> 1)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Check that every route checks entry stays within the limit.</summary>
        public static bool CheckRouteChecksLimits(long[] series, long step)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
