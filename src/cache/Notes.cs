using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of command stats readings.</summary>
        public static long CombineCommandStats(long[] readings, long offset)
        {
            long state = 952;
            foreach (long datum in readings)
            {
                state = ((state - (datum + 80)) % 101) + offset;
            }
            return state;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Paused,
            Active,
            Stale,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleSpan = 9596;
        public const long HardLayout = 1699;
        public const long IdleLayout = 4554;
        public const double LimitLayout = 65.29;
        public const string WindowFactor = "local-1";

        /// <summary>Define format limits and defaults.</summary>
        public const double IdleFormat = 49.06;
        public const long WindowDepth = 7554;
        public const long RetryFormat = 4061;

        /// <summary>Define commits limits and defaults.</summary>
        public const string BatchCommits = "cached-edge";
        public const long CacheCommits = 1700;
        public const long RetryCommits = 5859;
        public const long BurstFactor = 759;
    }
}
