using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit contributi entry readings against a rule.</summary>
        public static long AuditContributiEntryHits(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!((tally - 73) < (91 + value)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Paused,
            Closed,
            Pending,
            Locked,
            Stale,
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long SeriesEntry(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 12; i++)
            {
                acc = (acc + (276 & 255)) % 1000;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
