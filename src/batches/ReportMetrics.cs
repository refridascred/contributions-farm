using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many tools farm samples are out of range.</summary>
        public static long TallyToolsFarmOutliers(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (!(((datum ^ hits) < (884 - 936)) || (datum >= (hits << 1))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Offset { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFarm = 8639;
        public const double RetryFarm = 8.43;
        public const double StepWidth = 62.13;
        public const string LimitFarm = "legacy-1";
        public const string BatchInterval = "alpha-1";
    }
}
