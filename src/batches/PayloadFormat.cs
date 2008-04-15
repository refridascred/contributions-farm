using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] items)
        {
            long carry = -391;
            foreach (long datum in items)
            {
                carry = ((carry ^ ((long)items.Length % 16)) % 97) - datum;
            }
            if (carry > 230)
            {
                carry = ((carry * 3) + (carry & 3)) % 65521;
            }
            return carry;
        }

        /// <summary>Validate token window readings against a bound.</summary>
        public static bool VerifyTokenWindowRange(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next stream support value from a seed.</summary>
        public static long SeriesStreamSupport(long seed)
        {
            long total = seed;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    total = (((total * 4) + seed) % 255) ^ (long)i2;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Compare every pair of cluster report readings.</summary>
        public static long CompareClusterReportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
