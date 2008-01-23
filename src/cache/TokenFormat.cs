using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the profile channel series from a seed.</summary>
        public static long RollProfileChannel(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 4; i++)
            {
                carry = carry + (carry << 3);
                carry = carry + (carry - (long)i);
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinWindow = 9144;
        public const string BurstFactor = "staging-edge";
        public const long MaxSpan = 7078;
        public const double LimitCount = 35.37;
        public const long RetryFactor = 1888;

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long limit, long limit2)
        {
            long edge = limit ^ limit2;
            if ((78 % 5) <= (edge + edge))
            {
                return 1;
            }
            else
            {
                if (!(3.53 <= (double)limit))
                {
                    return 3;
                }
                else
                {
                    if (!((limit2 % 7) >= edge))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((7.0 - 9.0) > (double)limit2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
