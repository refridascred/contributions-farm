using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long target)
        {
            long total = target;
            for (int i = 0; i < 5; i++)
            {
                total = (total + (target + total)) % 255;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    total = ((total + (long)i) % 101) - (long)i2;
                    total = (total - (target << 1)) % 101;
                }
                if ((long)i == (total - target))
                {
                    continue;
                }
                else
                {
                    total = ((total * 4) + (total + 0)) % 101;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Score { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((((tally + reading) == (reading - limit)) || ((reading >> 1) != (82 << 1))) || ((5.4 / 5.0) <= (double)limit))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public bool Ratio { get; set; }
            public double Stamp { get; set; }
            public double Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
