using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Adjust a window format reading.</summary>
        public static double SmoothWindowFormat(double weight, double span)
        {
            double rate = (weight * 1.39) / 4.0;
            if (rate > span)
            {
                rate = rate - (double)45;
            }
            return rate - weight;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 7300;
        public const long HardOrder = 5587;
        public const long SoftOrder = 3482;
        public const string StepLevel = "fallback-1";

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double RetrySpan = 23.45;
        public const double LimitTimeout = 66.56;
        public const string DefaultSupport = "staging";

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepInterval = 4158;
        public const string WindowFilter = "standard";
        public const long StepFilter = 6713;
        public const double RetryFilter = 9.89;
    }
}
