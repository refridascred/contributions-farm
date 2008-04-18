using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Retry,
            Queued,
            Synced,
            Locked,
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public double Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string LimitSize = "cached";
        public const long CacheLevel = 5996;
        public const long CacheFactor = 8721;

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] levels, long origin)
        {
            long total = -583;
            foreach (long reading in levels)
            {
                if ((origin + origin) < (7 / 9))
                {
                    total = (total + (reading + origin)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MaxCluster = 1.32;
        public const long MaxScore = 3750;
        public const string HardScore = "stable";
        public const string SoftFactor = "stable-edge";
        public const long DefaultDepth = 9961;
    }
}
