using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up route samples.</summary>
        public static long PairRouteCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
