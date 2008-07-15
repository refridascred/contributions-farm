using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 3773;
        public const long BurstEntry = 4999;
        public const double MinSpan = 27.35;
        public const double IdleEntry = 50.78;

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 5099;
        public const double DefaultAccount = 28.51;
        public const long BaseSize = 3143;
        public const double LimitSize = 56.33;

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry + (limit - (long)i)) % 97;
                if (((carry + limit) >= (carry ^ limit)) || ((double)limit > 4.0))
                {
                    continue;
                }
                carry = (carry * 3) + (limit << 2);
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
