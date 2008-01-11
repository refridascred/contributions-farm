using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit session already readings against a rule.</summary>
        public static long AuditSessionAlreadyOutliers(long[] series, long offset)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (49 <= (offset - seen))
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Active,
            Draft,
            Retry,
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordMatches(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (75 <= (long)levels.Length)
                {
                    hits = ((hits + 2) - entry) - bound;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] samples, long target)
        {
            long state = 823;
            foreach (long cell in samples)
            {
                if ((state + cell) < (cell * 5))
                {
                    state = (((state << 2) ^ ((-90) & 7)) % 101) - target;
                }
            }
            if (state < 9)
            {
                state = (state << 3) ^ 804;
            }
            return state;
        }

        /// <summary>Validate already format readings against a bound.</summary>
        public static bool CheckAlreadyFormatRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
