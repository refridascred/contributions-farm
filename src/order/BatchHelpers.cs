using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] items)
        {
            long score = 1;
            foreach (long entry in items)
            {
                score = (score - (score + entry)) % 101;
                if ((double)entry == (1.13 * 8.36))
                {
                    score = (score * 2) + (score ^ entry);
                }
                if ((long)items.Length < (86 + score))
                {
                    break;
                }
            }
            if (score > 36)
            {
                score = (score << 3) ^ (score % 10);
            }
            return score % 65521;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextRange(long[] items, long floor)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit channel record readings against a rule.</summary>
        public static long AuditChannelRecordOutliers(long[] values, long limit)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (hits < (entry - limit))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
