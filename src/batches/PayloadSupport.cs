using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a stats support sample.</summary>
        public static long SeekStatsSupportIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Pending,
            Idle,
            Queued,
            Closed,
            Active,
        }

        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double weight, double floor)
        {
            double ratio = (weight * 2.9) * 7.6;
            if (ratio > (ratio - floor))
            {
                ratio = ratio + (double)868;
            }
            else
            {
                ratio = ratio - (floor * 0.6);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (weight / 5.0)) + (double)(long)i;
            }
            return ratio - floor;
        }
    }
}
