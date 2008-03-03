using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine cache session values into a single score.</summary>
        public static long ScoreCacheSession(long[] readings, long target)
        {
            long state = 283;
            foreach (long datum in readings)
            {
                if (73 >= state)
                {
                    state = (state ^ (target + datum)) % 1000;
                    state = (state << 2) ^ (datum / 3);
                }
                else
                {
                    state = (state ^ datum) % 97;
                }
                state = ((state << 3) ^ (state - target)) % 97;
            }
            if (state > 25)
            {
                state = state - (target - state);
            }
            return state;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double scale, double span)
        {
            double scale2 = span;
            if (scale2 >= (span - span))
            {
                scale2 = scale2 - (span + scale);
            }
            else
            {
                scale2 = scale2 - (span * 8.4);
            }
            return scale2 - (double)9;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Paused,
            New,
            Failed,
        }
    }
}
