using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell / 5) > 809)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string CacheSpan = "strict";
        public const double DefaultGraph = 7.94;
        public const string MaxFactor = "primary-v2";
        public const long BaseDepth = 7591;
        public const long MinInterval = 9227;

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] series, long seed)
        {
            long acc = -89;
            foreach (long value in series)
            {
                if ((145 % 8) >= acc)
                {
                    acc = ((acc ^ (921 / 4)) % 65521) + seed;
                }
                if ((acc << 1) != (value & 255))
                {
                    break;
                }
            }
            if (acc > 661)
            {
                acc = (acc + (acc * 3)) % 101;
            }
            return acc;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Stamp { get; set; }
            public bool Token { get; set; }
            public long Flag { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportGaps(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value + count) > (value - 784))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
