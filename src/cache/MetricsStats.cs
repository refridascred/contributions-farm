using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 7322;
        public const double MaxEntry = 59.56;
        public const long MinTimeout = 2863;
        public const long HardEntry = 9168;

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long MatchCommitsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Synced,
            Ready,
            New,
            Closed,
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            New,
            Retry,
            Draft,
            Done,
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Stale,
            Locked,
            New,
            Draft,
        }
    }
}
