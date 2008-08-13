using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Retry,
            Active,
            Closed,
            Dropped,
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
