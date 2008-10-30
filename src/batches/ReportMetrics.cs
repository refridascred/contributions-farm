using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank layout cluster input into a small class.</summary>
        public static long ClassifyLayoutCluster(long offset, long offset2)
        {
            if (!(offset <= (offset2 * 4)))
            {
                return 8;
            }
            else
            {
                if (offset2 >= (678 ^ 69))
                {
                    return 0;
                }
                else
                {
                    if (offset2 > (offset2 * 2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BatchOrder = "latest-v2";
        public const long IdleOrder = 6000;
        public const double WindowInterval = 31.7;
        public const double StepOrder = 45.97;
        public const long DefaultSize = 5693;

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public bool Level { get; set; }
            public string Weight { get; set; } = "";
            public double Region { get; set; }
        }
    }
}
