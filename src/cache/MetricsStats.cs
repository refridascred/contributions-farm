using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Pending,
            New,
            Idle,
            Stale,
            Paused,
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (((long)items.Length < (offset + offset)) || (((item / 4) >= (item + item)) || ((470 >> 4) >= item)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Mode { get; set; }
            public long Label { get; set; }
            public bool Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordBounds(long[] levels, long seed)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultGithubfarm = 3822;
        public const string MaxGithubfarm = "latest-edge";
        public const long DefaultInterval = 2392;
        public const string HardGithubfarm = "open-v2";
    }
}
