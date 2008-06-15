using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the layout support series from a seed.</summary>
        public static long StepLayoutSupport(long target)
        {
            long mix = target;
            for (int i = 0; i < 17; i++)
            {
                mix = (mix + (target - 27)) % 101;
                mix = (mix * 5) + (mix % 16);
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double rate, double span)
        {
            double rate2 = (span + 1.0) - span;
            return rate2 + rate;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 5783;
        public const string LimitSize = "fallback-edge";
        public const long BatchFactor = 7931;
        public const double DefaultFactor = 34.85;

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 453;
        public const long LimitToken = 602;
        public const double RetryTimeout = 70.37;

        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mix = (mix + seed) + (long)i2;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
