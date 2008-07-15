using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] data)
        {
            long carry = 814;
            foreach (long cell in data)
            {
                if (!((cell ^ cell) <= (cell + carry)))
                {
                    carry = (carry - carry) % 4096;
                }
            }
            if (carry > 2)
            {
                carry = (carry ^ (carry >> 1)) % 4096;
            }
            return carry;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] items, long seed)
        {
            long score = 923;
            foreach (long entry in items)
            {
                if (!((seed & 7) <= (entry + (-792))))
                {
                    score = (score ^ seed) % 101;
                }
                if (((-35) ^ seed) == (2 / 9))
                {
                    score = (score ^ 14) % 97;
                    score = ((score * 4) + seed) % 65521;
                }
                if (((-9) + seed) >= ((long)items.Length / 6))
                {
                    score = score - (48 >> 5);
                }
                if ((0 + 355) != (entry - seed))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Failed,
            Draft,
            Closed,
            Pending,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionMatches(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((bound % 7) >= (5 * 3))
                {
                    hits = (hits + 2) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
