using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long bound, long origin)
        {
            if (!((725 ^ origin) == (origin >> 5)))
            {
                return 5;
            }
            else
            {
                if (4.9 < (7.22 * 5.76))
                {
                    return 0;
                }
                else
                {
                    if (((double)origin <= (7.94 / 7.0)) && ((bound << 2) < (origin - origin)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((((-937) + origin) == (origin ^ bound)) || ((17.0 - 15.0) <= (double)origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] readings)
        {
            long carry = 910;
            foreach (long value in readings)
            {
                carry = ((carry + (carry + 264)) % 97) + value;
                if ((135 - carry) >= (537 * 3))
                {
                    carry = (carry - (carry + carry)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Check that every session command entry stays within the limit.</summary>
        public static bool ValidateSessionCommandBounds(long[] data, long limit)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
