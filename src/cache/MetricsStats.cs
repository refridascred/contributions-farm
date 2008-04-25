using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Score { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Count the filter metric entries that pass the check.</summary>
        public static long MeasureFilterMetricMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((double)sample == (double)83)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] items)
        {
            long acc = -8;
            foreach (long item in items)
            {
                if ((21 + item) < (item & 7))
                {
                    acc = acc ^ (acc + item);
                }
                if ((acc & 7) == (acc & 15))
                {
                    acc = (acc << 3) ^ (item % 10);
                }
                else
                {
                    acc = (acc << 3) ^ item;
                }
            }
            if (acc > 467)
            {
                acc = (acc << 2) ^ (acc - acc);
            }
            return acc;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public bool Level { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
