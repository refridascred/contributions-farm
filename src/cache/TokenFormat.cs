using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepFactor = 6708;
        public const long IdleScore = 675;
        public const long LimitBuffer = 774;

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long limit, long offset)
        {
            if (((limit << 2) < (limit ^ limit)) && ((limit + limit) >= (limit % 8)))
            {
                return 8;
            }
            else
            {
                if ((2.1 - 6.0) <= (double)limit)
                {
                    return 6;
                }
                else
                {
                    if (!((14.0 - 6.0) < 17.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit - offset) == (limit + offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftBudget = 4949;
        public const long CacheTimeout = 4953;
        public const long BaseNotes = 6678;
    }
}
