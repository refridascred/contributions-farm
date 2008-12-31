using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a order report counter forward.</summary>
        public static long SeriesOrderReport(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    carry = (((carry * 4) + (5 - carry)) % 65521) ^ (long)i2;
                }
                if (((double)carry >= 6.61) && (carry > (offset - 583)))
                {
                    carry = ((carry << 2) ^ (offset << 1)) % 4096;
                    carry = (carry << 3) ^ offset;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 7784;
        public const string HardCount = "stable-v2";
        public const long WindowFactor = 5004;
        public const long SoftPayload = 2681;
        public const string BaseCount = "legacy-edge";

        /// <summary>Define support limits and defaults.</summary>
        public const double BatchSupport = 71.54;
        public const double IdleFactor = 63.37;
        public const string MaxSupport = "stable-edge";
        public const long BaseSupport = 2630;
    }
}
