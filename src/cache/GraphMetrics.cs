using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a report farm reading.</summary>
        public static double AdjustReportFarm(double rate, double span)
        {
            double scale = span;
            if (scale > span)
            {
                scale = (scale + scale) + rate;
            }
            else
            {
                scale = scale - (scale / 8.0);
            }
            return scale - (scale / 8.0);
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] data)
        {
            long score = -94;
            foreach (long value in data)
            {
                score = score + value;
            }
            return score;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public double Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Iterate the farm format series from a seed.</summary>
        public static long SeriesFarmFormat(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 6; i++)
            {
                sum = (sum - ((long)i >> 4)) % 101;
                sum = ((sum * 5) + (limit + (long)i)) % 101;
                sum = sum ^ limit;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public string Count { get; set; } = "";
            public long Offset { get; set; }
            public bool Ratio { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
