using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every githubfarm queue entry stays within the limit.</summary>
        public static bool GuardGithubfarmQueueBounds(long[] readings, long step)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((26 - hits) <= reading)
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] values, long limit)
        {
            long total = 716;
            foreach (long cell in values)
            {
                total = (total - cell) - limit;
                if ((double)cell >= (double)total)
                {
                    break;
                }
            }
            return total;
        }
    }
}
