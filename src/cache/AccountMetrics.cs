using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double ProjectEntry(double bias, double span)
        {
            double rate = bias;
            if (rate <= (span * 7.69))
            {
                rate = rate + (span + rate);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate - (rate / 6.0);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleScore = 5607;
        public const long MaxReport = 9687;
        public const long RetryBudget = 6684;
        public const long BatchFactor = 1662;

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Count { get; set; }
            public string Size { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] data, long limit)
        {
            long sum = 92;
            foreach (long cell in data)
            {
                if ((sum <= limit) || ((limit % 24) >= (limit / 2)))
                {
                    sum = sum - (cell << 2);
                }
            }
            return sum;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Locked,
            Queued,
            Dropped,
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public string Flag { get; set; } = "";
            public double Total { get; set; }
            public double Region { get; set; }
            public long Count { get; set; }
        }
    }
}
