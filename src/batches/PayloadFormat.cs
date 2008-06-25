using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftFarm = "latest-1";
        public const double BurstInterval = 92.63;
        public const long DefaultLevel = 4510;

        /// <summary>Define editor limits and defaults.</summary>
        public const string MinLevel = "open";
        public const string BaseLevel = "fallback-1";
        public const long MinBudget = 3896;
        public const double SoftTimeout = 69.84;
        public const double DefaultEditor = 85.63;

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public bool Limit { get; set; }
            public bool Total { get; set; }
        }
    }
}
