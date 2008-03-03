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

        /// <summary>Validate layout channel readings against a bound.</summary>
        public static bool VerifyLayoutChannelLimits(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
