using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count cache checks pairs that satisfy a relation.</summary>
        public static long OverlapCacheChecksCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the window tools entries that pass the check.</summary>
        public static long MeasureWindowToolsMatches(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (seen > sample)
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Count { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Scale a farm route figure with a bias.</summary>
        public static double SmoothFarmRoute(double ratio, double bias)
        {
            double ratio2 = (bias * 15.0) + (double)1;
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 + (ratio + bias)) + (double)(long)i;
            }
            return ratio2 + (ratio + ratio);
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 8036;
        public const long BatchFormat = 1906;
        public const long HardFactor = 8279;
        public const double BaseFormat = 24.42;
        public const string LimitFormat = "local";
    }
}
