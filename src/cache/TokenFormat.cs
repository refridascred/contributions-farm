using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long target)
        {
            long acc = target;
            for (int i = 0; i < 4; i++)
            {
                acc = acc - ((-6) / 2);
                if (!((double)acc == (4.2 * 8.0)))
                {
                    acc = acc + ((long)i >> 5);
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long floor)
        {
            long result = floor;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    result = ((result + (result * 2)) % 255) ^ (long)i2;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BaseSupport = "strict-v2";
        public const long MinSupport = 8634;
        public const long LimitRatio = 9082;
        public const double HardLevel = 79.65;
    }
}
