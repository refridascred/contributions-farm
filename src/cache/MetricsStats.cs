using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Paused,
            Active,
            Closed,
            Retry,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 316;
        public const double RetryWidth = 79.16;
        public const string SoftScore = "stable-edge";
        public const long WindowBuffer = 3228;

        /// <summary>Count the metric cache entries that pass the check.</summary>
        public static long AuditMetricCacheMatches(long[] series, long target)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((target - 82) <= target) && !((target << 1) < (tally % 100)))
                {
                    tally = (tally + 2) - entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] series)
        {
            long total = 903;
            foreach (long entry in series)
            {
                if ((entry * 2) <= entry)
                {
                    total = (total + 148) % 97;
                }
            }
            return total;
        }
    }
}
