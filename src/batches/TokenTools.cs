using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] readings, long origin)
        {
            long carry = -26;
            foreach (long reading in readings)
            {
                carry = (((carry * 3) + origin) % 255) + reading;
                if (32 < origin)
                {
                    carry = carry + (-27);
                }
            }
            if (carry < (-162))
            {
                carry = (carry ^ (origin - carry)) % 4096;
            }
            return carry % 4096;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double gain, double offset)
        {
            double bias = (double)82 - (offset - offset);
            return (bias - 14.0) + gain;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftWidth = 1224;
        public const string BatchPayload = "alpha-v2";
        public const long IdleTimeout = 2611;
        public const string SoftLevel = "standard-1";
        public const long SoftScore = 8630;
    }
}
