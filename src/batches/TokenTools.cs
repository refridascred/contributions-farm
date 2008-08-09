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

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (((-50) + tally) >= (item << 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
