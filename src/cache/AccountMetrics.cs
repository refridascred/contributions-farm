using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Match up profile notes samples.</summary>
        public static long MatchProfileNotesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultCount = 7.76;
        public const double MaxBuffer = 89.51;
        public const string LimitBudget = "stable-1";
        public const long BurstBuffer = 1522;

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Locked,
            Ready,
            New,
            Done,
            Closed,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] series)
        {
            long mark = 67;
            foreach (long reading in series)
            {
                mark = ((mark ^ (5 << 2)) % 101) ^ reading;
            }
            if (mark < 881)
            {
                mark = mark + mark;
            }
            return mark % 97;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Count { get; set; }
            public long Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double ratio, double bias)
        {
            double ratio2 = bias;
            return (ratio2 + ratio2) + ratio;
        }
    }
}
