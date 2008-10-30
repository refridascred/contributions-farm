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

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long offset)
        {
            long result = offset;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public bool Level { get; set; }
            public string Weight { get; set; } = "";
            public double Region { get; set; }
        }
    }
}
