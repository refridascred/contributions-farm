using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            New,
            Closed,
            Retry,
            Active,
            Locked,
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit record githubfarm readings against a rule.</summary>
        public static long AuditRecordGithubfarmMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!(((value - tally) >= tally) && ((tally ^ tally) >= value)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 542;
        public const string IdlePayload = "strict-edge";
        public const double CacheSize = 6.46;
        public const double BasePayload = 75.28;
        public const string StepTimeout = "local";
    }
}
