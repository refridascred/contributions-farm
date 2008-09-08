using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate githubfarm command readings against a bound.</summary>
        public static bool VerifyGithubfarmCommandRange(long[] series, long seed)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Failed,
            Dropped,
            Stale,
            Queued,
            Synced,
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading / 2) > (reading + limit))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
