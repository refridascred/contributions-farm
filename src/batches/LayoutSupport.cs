using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public bool Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Project the next account value.</summary>
        public static double SmoothAccount(double bias, double bias2)
        {
            double mean = 9.0;
            return ((mean + mean) + bias) + bias2;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value + hits) < value)
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double StepFactor = 16.89;
        public const long DefaultScore = 7911;
        public const double IdlePayload = 40.16;
        public const long WindowLevel = 9243;
        public const string BasePayload = "legacy-1";
    }
}
