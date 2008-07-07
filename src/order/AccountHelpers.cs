using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchGaps(long[] items, long bound)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((8.4 * 7.01) < (double)value)
                {
                    tally = (tally + 2) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank profile layout input into a small class.</summary>
        public static long SortProfileLayout(long seed, long limit)
        {
            if ((double)limit >= (double)seed)
            {
                return 8;
            }
            else
            {
                if ((seed ^ seed) > (limit ^ limit))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Label { get; set; }
            public double Owner { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Adjust a context account reading.</summary>
        public static double SmoothContextAccount(double weight, double span)
        {
            double rate = weight - (weight + weight);
            if (rate >= (rate - 4.22))
            {
                rate = (rate + (4.9 / 2.0)) + span;
            }
            return rate + (weight / 8.0);
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultProfile = 70.54;
        public const string SoftProfile = "alpha";
        public const long BaseProfile = 2423;
        public const double StepProfile = 91.88;

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public double Stamp { get; set; }
            public bool Rank { get; set; }
            public long Ratio { get; set; }
        }
    }
}
