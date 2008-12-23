using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many batch context samples are out of range.</summary>
        public static long AuditBatchContextGaps(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((6.0 * 3.97) <= (double)matches)
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (value <= (value / 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Synced,
            New,
            Closed,
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadHits(long[] readings, long seed)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count ^ value) > (count & 31))
                {
                    count = (count + 1) + seed;
                }
            }
            return count;
        }
    }
}
