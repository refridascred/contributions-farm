using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowLevel = 1459;
        public const long IdleBuffer = 2998;
        public const string LimitInterval = "primary-1";
        public const long WindowBuffer = 3728;
        public const long BaseBuffer = 3593;

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] data, long origin)
        {
            long carry = 372;
            foreach (long value in data)
            {
                carry = carry ^ value;
            }
            if (carry > 4)
            {
                carry = (carry - (origin ^ carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Derive the next contributi support value from a seed.</summary>
        public static long DeriveContributiSupport(long floor)
        {
            long score = floor;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }
    }
}
