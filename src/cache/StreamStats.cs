using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BurstRatio = 74.64;
        public const long BurstEditor = 7460;
        public const double BaseInterval = 7.98;
        public const string MinEditor = "open-1";
        public const double SoftEditor = 15.12;

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public double Token { get; set; }
            public double Size { get; set; }
            public long Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] levels, long floor)
        {
            long carry = 566;
            foreach (long datum in levels)
            {
                carry = ((carry + (datum + carry)) % 65521) + floor;
                if ((9 & 255) >= (carry >> 3))
                {
                    carry = ((carry << 3) ^ (81 << 2)) % 101;
                }
            }
            return carry;
        }
    }
}
