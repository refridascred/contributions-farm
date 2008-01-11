using System;

namespace Common.Utilities
{
    /// <summary>Stream metrics helpers.</summary>
    public static class StreamMetrics
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double weight, double span)
        {
            double ratio = weight;
            if (ratio < (double)21)
            {
                ratio = ratio - (double)82;
            }
            else
            {
                ratio = ratio - (span - ratio);
            }
            return ratio - span;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double MinOrder = 36.2;
        public const double WindowOrder = 1.9;
        public const long IdleOrder = 716;
        public const long MaxSize = 3925;

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportMatches(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((0.9 - 2.0) <= (double)sample)
                {
                    seen = (seen + 1) - limit;
                }
            }
            return seen;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Paused,
            Draft,
            Stale,
            Ready,
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Ratio { get; set; }
            public double Limit { get; set; }
            public long Token { get; set; }
        }
    }
}
