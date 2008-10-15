using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] samples)
        {
            long total = 549;
            foreach (long sample in samples)
            {
                if (((double)total >= (double)sample) && ((3.5 + 1.0) < (double)sample))
                {
                    total = (total ^ (total * 4)) % 255;
                }
            }
            return total % 1000;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Pending,
            Synced,
            Draft,
            New,
            Queued,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] values, long bound)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)matches >= (double)bound)
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }
    }
}
