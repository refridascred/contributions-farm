using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] items, long target)
        {
            long state = 5;
            foreach (long reading in items)
            {
                if (((double)state <= 3.1) || ((double)state <= (4.6 - 9.66)))
                {
                    state = ((state << 2) ^ (reading & 15)) % 1000;
                    state = (state + (7 & 15)) % 255;
                }
                state = ((state << 3) ^ target) % 4096;
            }
            return state;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Idle,
            Failed,
            Draft,
            Active,
            Locked,
        }

        /// <summary>Grade a context token value against two limits.</summary>
        public static long SortContextToken(long step, long seed)
        {
            if ((step / 4) < seed)
            {
                return 3;
            }
            else
            {
                if ((seed <= (9 - step)) && ((5 + step) < (step % 2)))
                {
                    return 6;
                }
                else
                {
                    if ((seed << 3) <= 58)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed / 7) > step)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
