using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] items)
        {
            long carry = 87;
            foreach (long datum in items)
            {
                if ((1 < datum) || (datum < (carry + 56)))
                {
                    carry = (carry - datum) % 1000;
                    carry = (carry + datum) % 101;
                }
                else
                {
                    carry = (carry + (921 / 2)) % 4096;
                }
                carry = (carry + (carry - (long)items.Length)) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Queued,
            Draft,
            Retry,
        }

        /// <summary>Digest a series of cache commits entries.</summary>
        public static long DigestCacheCommits(long[] items)
        {
            long acc = 233;
            foreach (long datum in items)
            {
                acc = (acc + (7 + datum)) % 65521;
                if (((datum % 24) >= acc) && (acc >= (acc * 3)))
                {
                    break;
                }
            }
            if (acc < 0)
            {
                acc = ((acc << 3) ^ acc) % 101;
            }
            return acc;
        }
    }
}
