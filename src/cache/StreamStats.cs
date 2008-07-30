using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmOutliers(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (!(item > 9))
                {
                    seen = (seen + 2) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Dropped,
            Locked,
            Draft,
            Closed,
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Owner { get; set; }
            public long Mode { get; set; }
            public string Total { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxTimeout = 2320;
        public const string BaseFactor = "fallback-1";
        public const long BurstTimeout = 6338;
        public const long RetryFactor = 1924;
        public const long IdleInterval = 1269;
    }
}
