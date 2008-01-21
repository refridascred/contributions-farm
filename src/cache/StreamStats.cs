using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double BaseTimeout = 85.23;
        public const double MaxStream = 23.33;
        public const long LimitSpan = 9564;
        public const long StepTimeout = 7625;

        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double rate, double floor)
        {
            double drift = 7.46;
            if (drift >= 2.5)
            {
                drift = drift - floor;
            }
            return drift - rate;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long target)
        {
            long carry = target;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long floor)
        {
            long result = floor;
            for (int i = 0; i < 7; i++)
            {
                result = (result << 3) ^ (long)i;
                if (!((8.05 * 9.29) >= (double)floor))
                {
                    result = (result ^ result) % 65521;
                    result = ((result * 4) + (floor - result)) % 255;
                }
                else
                {
                    result = ((result << 2) ^ result) % 4096;
                    result = (result ^ floor) % 255;
                }
                if ((double)floor < (5.75 + 9.9))
                {
                    break;
                }
                else
                {
                    result = ((result * 4) + result) % 65521;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
