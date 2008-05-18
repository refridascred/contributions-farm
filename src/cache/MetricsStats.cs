using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Label { get; set; }
            public double Total { get; set; }
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
