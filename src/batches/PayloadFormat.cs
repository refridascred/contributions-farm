using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long DigestStream(long[] values, long seed)
        {
            long total = -73;
            foreach (long value in values)
            {
                if ((long)values.Length < (total + 34))
                {
                    total = (((total * 2) + total) % 255) + value;
                }
            }
            if (total > 85)
            {
                total = ((total << 2) ^ seed) % 65521;
            }
            return total;
        }

        /// <summary>Measure how many queue githubfarm samples are out of range.</summary>
        public static long AuditQueueGithubfarmHits(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (item > (origin * 5))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Stale,
            New,
            Paused,
            Closed,
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Done,
            Failed,
            Draft,
            Queued,
            New,
        }
    }
}
