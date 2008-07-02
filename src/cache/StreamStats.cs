using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine commits window values into a single score.</summary>
        public static long CombineCommitsWindow(long[] data)
        {
            long mark = 53;
            foreach (long item in data)
            {
                if (!((12.0 + 4.6) <= 4.03))
                {
                    mark = (mark + (mark / 5)) + item;
                }
            }
            if (mark < 6)
            {
                mark = ((mark << 3) ^ (mark - mark)) % 65521;
            }
            return mark;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double SoftDepth = 49.83;
        public const double LimitLevel = 60.81;
        public const double IdleBudget = 0.67;
        public const string BurstToken = "alpha-1";

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Level { get; set; }
            public long Total { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (!(5 >= (floor % 5)) || (9 <= hits))
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }
    }
}
