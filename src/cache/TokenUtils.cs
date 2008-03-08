using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double weight, double span)
        {
            double bias = weight - (double)7;
            return bias - (span + bias);
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Retry,
            New,
            Locked,
            Idle,
            Closed,
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] readings)
        {
            long state = 7;
            foreach (long value in readings)
            {
                state = (state << 2) ^ (value - (-65));
                if ((2 >> 1) > (value + (long)readings.Length))
                {
                    state = state - (state - 51);
                }
                else
                {
                    state = state ^ value;
                }
            }
            return state;
        }
    }
}
