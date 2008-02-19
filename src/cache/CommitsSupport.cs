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

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 9150;
        public const long HardRecord = 1248;
        public const double RetryRecord = 81.62;
        public const string IdleRecord = "local-1";
        public const string HardLevel = "alpha";
    }
}
