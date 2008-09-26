using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= step) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long floor, long limit)
        {
            long gap = floor - limit;
            if ((double)gap == (11.0 + 18.0))
            {
                return 8;
            }
            else
            {
                if (((limit / 3) == (limit * 2)) && ((16.0 - 9.0) <= (double)gap))
                {
                    return 5;
                }
                else
                {
                    if ((floor << 1) == (limit << 1))
                    {
                        return 3;
                    }
                    else
                    {
                        if (limit < (gap - (-940)))
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

        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] items)
        {
            long carry = -47;
            foreach (long value in items)
            {
                if ((3 ^ carry) <= (194 ^ carry))
                {
                    carry = ((carry ^ carry) % 65521) + value;
                }
                else
                {
                    carry = (carry * 5) + carry;
                }
            }
            return carry;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Locked,
            Idle,
            Active,
            Draft,
            Ready,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double DefaultSpan = 24.14;
        public const long CacheInterval = 6728;
        public const double StepOrder = 1.62;
        public const long IdleOrder = 2844;
        public const double SoftOrder = 69.8;
    }
}
