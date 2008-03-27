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

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public string Flag { get; set; } = "";
            public string Size { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double RetrySpan = 23.45;
        public const double LimitTimeout = 66.56;
        public const string DefaultSupport = "staging";

        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
