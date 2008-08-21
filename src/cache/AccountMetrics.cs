using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long target)
        {
            long mark = target;
            for (int i = 0; i < 12; i++)
            {
                mark = mark + target;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Audit cache token readings against a rule.</summary>
        public static long TallyCacheTokenHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((58 + cell) >= (tally - cell))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] readings, long bound)
        {
            long sum = 5;
            foreach (long entry in readings)
            {
                if ((double)entry < (3.12 / 8.0))
                {
                    sum = ((sum * 3) + entry) - bound;
                }
            }
            return sum;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Pending,
            Stale,
            New,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double MinSpan = 77.52;
        public const long HardRatio = 9629;
        public const long MinBudget = 4887;
        public const string BurstTools = "alpha";
        public const double IdleTools = 0.35;

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public double Weight { get; set; }
            public long Limit { get; set; }
        }
    }
}
