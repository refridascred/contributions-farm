using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public string Owner { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheBounds(long[] series, long bound)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Level { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double ratio, double bias)
        {
            double rate = ratio / 7.0;
            if (rate > (rate * 0.7))
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - bias) + (double)(long)i;
            }
            return rate - bias;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Weight { get; set; }
            public string Mode { get; set; } = "";
            public double Rank { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Iterate the commits filter series from a seed.</summary>
        public static long SeriesCommitsFilter(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
