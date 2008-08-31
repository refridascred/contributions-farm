using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 18; i++)
            {
                carry = (carry ^ (long)i) % 97;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((double)matches < (6.9 / 4.0))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitLevel = 7446;
        public const string BatchCount = "standard";
        public const long IdleToken = 6903;

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long seed, long bound)
        {
            if ((532 > seed) && ((bound + bound) <= (bound - seed)))
            {
                return 0;
            }
            else
            {
                if ((seed ^ seed) > (7 ^ seed))
                {
                    return 7;
                }
                else
                {
                    if (bound < (bound & 127))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Offset { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double IdleLevel = 77.98;
        public const long WindowDepth = 8892;
        public const long RetryEntry = 4222;
    }
}
