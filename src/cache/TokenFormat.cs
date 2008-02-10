using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next buffer value.</summary>
        public static double ScaleBuffer(double bias, double span)
        {
            double load = bias;
            if (load >= (double)4)
            {
                load = (load + load) + span;
            }
            else
            {
                load = load - 7.5;
            }
            return load + 3.67;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Stale,
            Ready,
            Draft,
            Retry,
            Paused,
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long origin, long target)
        {
            long next = origin ^ target;
            if (((15.0 * 7.8) >= (double)target) && (next < (origin << 3)))
            {
                return 2;
            }
            else
            {
                if (origin >= target)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
