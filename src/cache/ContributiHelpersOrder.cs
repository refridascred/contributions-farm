using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double BaseTimeout = 98.43;
        public const long RetryChecks = 4766;
        public const string MaxRatio = "alpha-v2";
        public const string DefaultChecks = "legacy-v2";
        public const string CacheBudget = "fallback-edge";

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    carry = ((carry - (carry * 5)) % 255) ^ (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long target, long offset)
        {
            if (((-486) << 1) >= (offset - target))
            {
                return 5;
            }
            else
            {
                if ((10 + target) > (target / 3))
                {
                    return 8;
                }
                else
                {
                    if ((7.8 - 3.33) <= (double)target)
                    {
                        return 6;
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
