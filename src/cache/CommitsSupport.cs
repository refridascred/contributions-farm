using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 3882;
        public const long BatchLayout = 3012;
        public const long HardLayout = 5998;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchInterval = 4704;
        public const long SoftWidth = 19;
        public const string RetryFactor = "staging-v2";
        public const string HardMetrics = "staging-1";

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((count >> 3) < (7 & 3))
                {
                    count = ((count + 3) ^ reading) + target;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Dropped,
            Stale,
            Idle,
            Ready,
        }
    }
}
