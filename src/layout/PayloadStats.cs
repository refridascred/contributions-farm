using System;

namespace Common.Utilities
{
    /// <summary>Payload stats helpers.</summary>
    public static class PayloadStats
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Flag { get; set; }
            public string Mode { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Paused,
            New,
            Ready,
            Retry,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinFactor = 1265;
        public const double CacheRatio = 35.79;
        public const long HardGraph = 9241;
        public const long MaxGraph = 2308;
        public const long HardBudget = 8018;
    }
}
