using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Failed,
            Done,
            Retry,
        }

        /// <summary>Audit githubfarm payload readings against a rule.</summary>
        public static long AuditGithubfarmPayloadMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((214 + value) < (value / 7))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BurstEditor = 73.02;
        public const long BurstWidth = 6303;
        public const long LimitEditor = 1803;
        public const long MinEditor = 9872;
        public const string LimitSize = "fallback";

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchDepth = 3636;
        public const long SoftSize = 5908;
        public const string SoftMetric = "fallback-edge";
        public const long BaseMetric = 685;
        public const string MaxMetric = "open-1";

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long seed)
        {
            long result = seed;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
