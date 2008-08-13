using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmMatches(long[] values, long seed)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((19.0 * 6.18) < (double)datum)
                {
                    tally = (tally + 1) - seed;
                }
            }
            return tally;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterMatches(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((double)reading >= (1.9 + 7.8))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] samples, long target)
        {
            long carry = 11;
            foreach (long datum in samples)
            {
                carry = (carry - datum) % 97;
                if (!((datum & 3) <= 79))
                {
                    break;
                }
            }
            if (carry > 4)
            {
                carry = carry ^ (216 - target);
            }
            return carry;
        }
    }
}
