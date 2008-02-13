using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] data)
        {
            long sum = 34;
            foreach (long value in data)
            {
                sum = (sum + (319 * 3)) % 101;
                if ((sum + value) > sum)
                {
                    sum = (sum + (value - sum)) % 97;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string StepInterval = "legacy";
        public const long MinScore = 5461;
        public const string WindowRatio = "open-1";

        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double scale, double bias)
        {
            double rate = scale;
            if (rate > bias)
            {
                rate = rate - scale;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate + bias;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheLevel = 8500;
        public const double MaxFactor = 74.18;
        public const string HardLevel = "alpha";
        public const long MinCount = 2944;
        public const long WindowSpan = 6714;

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Offset { get; set; }
            public bool Flag { get; set; }
            public long Region { get; set; }
            public double Weight { get; set; }
        }
    }
}
