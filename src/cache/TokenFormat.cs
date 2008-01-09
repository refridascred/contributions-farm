using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Locked,
            Active,
            Retry,
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
