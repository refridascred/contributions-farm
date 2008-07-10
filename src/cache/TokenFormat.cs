using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the farm entry entries that pass the check.</summary>
        public static long TallyFarmEntryOutliers(long[] samples, long target)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell / 8) < target)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Stale,
            Dropped,
            Queued,
            Active,
            Paused,
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordHits(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample % 8) <= (hits + sample))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
