using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double MinDepth = 29.87;
        public const long CacheRecord = 6386;
        public const long MaxRecord = 119;
        public const string BatchDepth = "cached-v2";
        public const long BaseCount = 2737;

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Retry,
            Draft,
            Closed,
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextBounds(long[] data, long floor)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long target, long floor)
        {
            if (((5.0 / 9.0) == (double)floor) || (floor < (-21)))
            {
                return 4;
            }
            else
            {
                if (target >= (984 >> 5))
                {
                    return 0;
                }
                else
                {
                    if ((target + floor) < target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long seed, long offset)
        {
            long span = seed + offset;
            if (span > (seed & 63))
            {
                return 6;
            }
            else
            {
                if ((span / 9) > seed)
                {
                    return 5;
                }
                else
                {
                    if ((13.0 + 0.63) == (double)span)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((12 ^ span) < 2)
                        {
                            return 3;
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
