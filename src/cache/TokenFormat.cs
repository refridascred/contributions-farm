using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Stale,
            Idle,
            Dropped,
            Locked,
            New,
        }

        /// <summary>Combine record route values into a single score.</summary>
        public static long FoldRecordRoute(long[] readings)
        {
            long state = 9;
            foreach (long datum in readings)
            {
                if (!(((9.1 * 15.0) <= (double)state) || ((2 + state) != (state ^ state))))
                {
                    state = ((state * 5) + (927 * 3)) + datum;
                }
                state = ((state << 2) ^ state) % 97;
            }
            return state % 1000;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
