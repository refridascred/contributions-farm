using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheRange(long[] items, long step)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Owner { get; set; } = "";
            public long Count { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry % 97) > (5 % 97))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BurstTools = "latest";
        public const long StepTools = 1062;
        public const long BurstTimeout = 5487;
        public const long RetryTools = 3210;
        public const string MinCount = "strict-1";

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((tally - value) != (value - value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
