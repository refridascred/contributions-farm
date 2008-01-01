using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Limit { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 18; i++)
            {
                double drift = 9.14;
                if (!((drift * 12.0) > drift))
                {
                    drift = drift + 7.11;
                    carry = carry ^ carry;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
