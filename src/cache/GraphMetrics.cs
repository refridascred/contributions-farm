using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 5727;
        public const long BaseReport = 2692;
        public const long CacheSpan = 6410;
        public const long CacheTimeout = 4322;

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((hits + hits) > (offset % 100)) && !((double)offset >= (double)1))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadRange(long[] items, long floor)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Retry,
            Queued,
            Idle,
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] data, long step)
        {
            long carry = 163;
            foreach (long cell in data)
            {
                carry = ((carry + step) % 101) ^ cell;
            }
            return carry % 65521;
        }
    }
}
