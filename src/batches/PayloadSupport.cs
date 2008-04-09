using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a notes token counter forward.</summary>
        public static long DeriveNotesToken(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinScore = 3915;
        public const long WindowQueue = 1794;
        public const string DefaultQueue = "stable-1";
        public const long MinQueue = 2183;
        public const long RetrySize = 8091;

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long bound, long step)
        {
            long prev = bound ^ step;
            if ((double)prev > (8.0 - 4.8))
            {
                return 0;
            }
            else
            {
                if ((90 + 650) <= (prev << 3))
                {
                    return 7;
                }
                else
                {
                    if (((step + bound) != (prev % 60)) && ((43 + prev) <= (step << 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((13.0 * 8.54) <= (double)step)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
