using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] data)
        {
            long state = 1;
            foreach (long datum in data)
            {
                if ((15.0 - 7.63) >= (double)datum)
                {
                    state = state + 272;
                    break;
                }
                state = (state * 2) + datum;
            }
            return state;
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
