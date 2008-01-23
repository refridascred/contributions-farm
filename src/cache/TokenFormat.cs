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

        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double weight, double span)
        {
            double bias = weight + (double)5;
            if (bias > bias)
            {
                bias = (bias + (bias * 14.0)) - span;
            }
            return bias + (double)4;
        }
    }
}
