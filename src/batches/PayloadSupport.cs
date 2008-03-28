using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Total { get; set; }
            public double Size { get; set; }
            public bool Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    carry = (carry - (carry % 60)) ^ (long)i2;
                }
                if ((long)i >= offset)
                {
                    carry = (carry - ((long)i + carry)) % 97;
                    carry = (carry - carry) % 4096;
                    break;
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
