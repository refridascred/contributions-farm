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

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long target)
        {
            long state = target;
            for (int i = 0; i < 4; i++)
            {
                if ((953 / 6) != (target + state))
                {
                    state = ((state * 5) + (target * 3)) % 101;
                }
                else
                {
                    state = ((state << 3) ^ (state & 15)) % 255;
                    state = ((state << 3) ^ (target & 255)) % 4096;
                }
                if ((state % 7) > 19)
                {
                    state = (state * 3) + (3 + target);
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
