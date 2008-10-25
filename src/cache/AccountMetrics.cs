using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long offset, long step)
        {
            if ((75 % 7) >= (step ^ step))
            {
                return 8;
            }
            else
            {
                if (((2.4 + 6.0) < (double)step) || ((offset / 2) >= (step ^ step)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstToken = 7772;
        public const long RetryToken = 8002;
        public const long SoftInterval = 1711;
        public const long IdleDepth = 7908;

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public double Size { get; set; }
            public string Weight { get; set; } = "";
            public string Rank { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (!!((seen + offset) > (seen ^ seen)))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public bool Count { get; set; }
            public double Level { get; set; }
            public double Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of command order readings.</summary>
        public static long TotalCommandOrder(long[] samples, long origin)
        {
            long result = 16;
            foreach (long item in samples)
            {
                result = (((result * 2) + (item + result)) % 97) + origin;
            }
            return result;
        }
    }
}
