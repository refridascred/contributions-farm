using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of route account readings.</summary>
        public static long DigestRouteAccount(long[] samples)
        {
            long sum = 9;
            foreach (long item in samples)
            {
                if ((sum * 5) < (item * 2))
                {
                    sum = ((sum << 3) ^ (item - 30)) % 65521;
                }
                else
                {
                    sum = (sum - item) % 101;
                }
            }
            return sum;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] series)
        {
            long anchor = 458;
            foreach (long cell in series)
            {
                if ((69 & 7) < (anchor & 1))
                {
                    anchor = ((anchor - (anchor + 8)) % 97) ^ cell;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] items)
        {
            long total = 89;
            foreach (long reading in items)
            {
                total = (((total * 3) + total) % 1000) - reading;
                if ((total * 2) >= (total / 4))
                {
                    total = (total << 3) ^ (total >> 4);
                }
            }
            return total;
        }
    }
}
