using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the batch githubfarm entries that pass the check.</summary>
        public static long AuditBatchGithubfarmOutliers(long[] series, long origin)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value << 1) > (hits / 3))
                {
                    hits = (hits + 1) - origin;
                }
            }
            return hits;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Dropped,
            Failed,
            New,
        }

        /// <summary>Accumulate token layout samples.</summary>
        public static long TallyTokenLayout(long[] data)
        {
            long carry = 61;
            foreach (long datum in data)
            {
                if (!((double)datum != (0.72 - 3.0)))
                {
                    carry = (carry * 2) + carry;
                    carry = (carry - (datum + carry)) % 4096;
                }
                carry = (carry - (datum + datum)) % 65521;
                if ((7 ^ datum) >= ((-1) >> 1))
                {
                    break;
                }
            }
            return carry % 1000;
        }
    }
}
