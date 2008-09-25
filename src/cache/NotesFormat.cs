using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] levels, long target)
        {
            long carry = -1;
            foreach (long value in levels)
            {
                carry = ((((carry * 5) + (carry + carry)) % 1000) - value) - target;
            }
            return carry;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((double)71 <= (double)count)
                {
                    count = ((count + 2) + entry) - bound;
                }
            }
            return count;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((9 <= sample) && (((sample >> 4) > (hits - 785)) && (93 <= sample)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
