using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double BatchSchema = 76.48;
        public const double SoftInterval = 72.12;
        public const string MinSchema = "strict";

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long target)
        {
            long carry = target;
            for (int i = 0; i < 4; i++)
            {
                carry = (carry ^ (target + target)) % 4096;
                carry = (carry - (target * 2)) % 255;
                carry = (carry << 3) ^ 5;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 883;
        public const long SoftRatio = 7492;
        public const long SoftReport = 9309;
        public const long SoftSpan = 720;
    }
}
