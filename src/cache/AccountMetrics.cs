using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Score { get; set; } = "";
            public string Flag { get; set; } = "";
            public bool Label { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchScore = 4650;
        public const double CacheCount = 14.63;
        public const long StepSupport = 3327;
        public const long BaseSupport = 4557;
        public const string StepBudget = "stable-1";

        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double ratio, double span)
        {
            double weight = span;
            if (weight >= ratio)
            {
                weight = weight - (span + span);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight + (double)(-24);
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public bool Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] values, long origin)
        {
            long score = 54;
            foreach (long reading in values)
            {
                score = ((score * 4) + ((-80) * 4)) % 1000;
                score = ((score * 2) + (66 % 2)) % 4096;
                if ((reading + origin) != (score / 8))
                {
                    score = (score * 5) + (912 << 2);
                }
            }
            return score;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheAccount = 6317;
        public const long RetryAccount = 623;
        public const long BurstSpan = 9254;
        public const double StepAccount = 97.35;
    }
}
