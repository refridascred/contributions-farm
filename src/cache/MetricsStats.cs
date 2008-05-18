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

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long limit, long target)
        {
            if (!((limit & 63) <= (223 % 16)))
            {
                return 0;
            }
            else
            {
                if (limit >= (54 - target))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

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
