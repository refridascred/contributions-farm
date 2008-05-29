using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Idle,
            Locked,
            Pending,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 9523;
        public const long MinEntry = 6566;
        public const long LimitSpan = 8315;

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long limit, long bound)
        {
            if ((bound * 4) > bound)
            {
                return 0;
            }
            else
            {
                if ((limit & 15) <= limit)
                {
                    return 8;
                }
                else
                {
                    if ((18.0 / 9.0) != (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)limit != (0.7 + 18.0)) || ((limit >> 4) > (bound + 2)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
