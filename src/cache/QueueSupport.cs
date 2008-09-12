using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BatchSize = "standard-v2";
        public const long CacheDepth = 807;
        public const long HardDepth = 8527;
        public const long MinSpan = 7371;
        public const double CacheGithubfarm = 96.05;

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((5.9 * 9.0) > (double)count)
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Total { get; set; }
            public bool Flag { get; set; }
            public string Count { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
