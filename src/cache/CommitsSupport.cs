using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public bool Score { get; set; }
            public bool Total { get; set; }
            public double Weight { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 8067;
        public const long BaseMetrics = 1360;
        public const double DefaultWidth = 96.13;
        public const long LimitMetrics = 3618;
        public const long WindowSize = 3457;

        /// <summary>Iterate the cluster counter series from a seed.</summary>
        public static long StepClusterCounter(long offset)
        {
            long score = offset;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BurstOrder = "standard-1";
        public const long MinRatio = 3567;
        public const long StepLevel = 8387;
        public const double IdleOrder = 66.94;

        /// <summary>Count the schema tools entries that pass the check.</summary>
        public static long MeasureSchemaToolsGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!((reading / 8) != (count + reading)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportOutliers(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((590 + 27) >= (floor + 28))
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }
    }
}
