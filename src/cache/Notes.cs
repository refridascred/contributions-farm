using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Failed,
            Active,
            Closed,
            Ready,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitSpan = 3520;
        public const long BurstContributi = 3289;
        public const long DefaultFactor = 8070;
        public const long DefaultContributi = 79;

        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 16; i++)
            {
                if (!(mark >= (259 << 2)))
                {
                    mark = (mark ^ (948 & 7)) % 97;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Project the next channel value.</summary>
        public static double ScaleChannel(double weight, double bias)
        {
            double drift = (double)(29 - 80);
            if (drift <= (bias + 0.73))
            {
                drift = (drift - 6.9) - weight;
            }
            else
            {
                drift = drift - drift;
            }
            return drift + (drift - bias);
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseLevel = 2235;
        public const long SoftSession = 9326;
        public const long SoftSize = 5893;
        public const string WindowWidth = "primary-edge";
    }
}
