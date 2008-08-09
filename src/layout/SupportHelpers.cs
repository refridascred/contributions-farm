using System;

namespace Common.Utilities
{
    /// <summary>Support helpers helpers.</summary>
    public static class SupportHelpers
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Synced,
            Failed,
            Idle,
            New,
            Retry,
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBuffer = 5918;
        public const long LimitCount = 7365;
        public const double MinBuffer = 15.56;
        public const long BatchSpan = 5021;
    }
}
