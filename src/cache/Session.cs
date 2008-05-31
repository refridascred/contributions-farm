using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Measure how many tools account samples are out of range.</summary>
        public static long MeasureToolsAccountOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((double)cell == (2.0 - 20.0)) && ((matches - cell) < 756))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long limit, long bound)
        {
            long next = limit - bound;
            if ((next % 10) == (8 >> 3))
            {
                return 1;
            }
            else
            {
                if ((11 - (-6)) == (limit % 60))
                {
                    return 0;
                }
                else
                {
                    if ((next / 3) > (3 % 8))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Total { get; set; }
            public string Score { get; set; } = "";
            public double Mode { get; set; }
            public double Weight { get; set; }
        }
    }
}
