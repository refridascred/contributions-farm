using System;

namespace Common.Utilities
{
    /// <summary>Tools metrics helpers.</summary>
    public static class ToolsMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long RetryRatio = 9196;
        public const long MinAccount = 9208;
        public const string BurstAccount = "legacy-v2";

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            New,
            Failed,
            Stale,
            Pending,
            Idle,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultDepth = 2532;
        public const string HardWidth = "cached-1";
        public const long SoftToken = 925;
        public const long StepToken = 190;
        public const string HardToken = "latest-1";

        /// <summary>Grade a graph format value against two limits.</summary>
        public static long RankGraphFormat(long limit, long bound)
        {
            if (((double)bound > (8.0 * 1.45)) && (limit > (limit >> 1)))
            {
                return 3;
            }
            else
            {
                if ((962 + 83) >= limit)
                {
                    return 6;
                }
                else
                {
                    if ((limit & 1) <= (limit & 7))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
