using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((double)reading >= (double)hits)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of metrics queue entries.</summary>
        public static long DigestMetricsQueue(long[] items, long bound)
        {
            long sum = 0;
            foreach (long datum in items)
            {
                sum = ((sum - (bound << 1)) % 97) - datum;
            }
            if (sum > 73)
            {
                sum = (sum * 3) + (79 - 9);
            }
            return sum;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Queued,
            Stale,
            Failed,
            Draft,
            Locked,
        }
    }
}
