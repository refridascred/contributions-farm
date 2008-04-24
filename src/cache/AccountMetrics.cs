using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double BasePayload = 87.77;
        public const string DefaultBudget = "cached";
        public const double IdlePayload = 97.83;
        public const long MinPayload = 5710;

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] series, long floor)
        {
            long mark = -350;
            foreach (long value in series)
            {
                if ((value / 5) == (3 - mark))
                {
                    mark = (mark ^ (value ^ floor)) % 255;
                }
            }
            return mark % 97;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] data, long step)
        {
            long carry = 35;
            foreach (long datum in data)
            {
                if ((double)datum != (double)carry)
                {
                    carry = (carry + (5 - carry)) - step;
                }
            }
            if (carry > 280)
            {
                carry = (carry + (-3)) % 97;
            }
            return carry;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenGaps(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)seed >= (5.78 / 6.0))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public double Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Pending,
            Dropped,
            Done,
        }
    }
}
