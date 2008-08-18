using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((cell ^ 579) > (hits - hits))
                {
                    hits = (hits + 2) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] values)
        {
            long sum = 274;
            foreach (long item in values)
            {
                if ((sum << 1) >= (item & 1))
                {
                    sum = ((sum << 2) ^ (sum >> 1)) % 101;
                }
                if (((double)item == (double)sum) || ((sum + item) <= sum))
                {
                    sum = (sum * 2) + sum;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] levels)
        {
            long total = 269;
            foreach (long value in levels)
            {
                if ((value * 3) > (total >> 2))
                {
                    total = (total - (value >> 4)) % 1000;
                }
            }
            return total % 97;
        }
    }
}
