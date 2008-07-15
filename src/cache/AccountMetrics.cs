using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Closed,
            Stale,
            New,
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double rate, double offset)
        {
            double ratio = (double)(88 - 798);
            if (ratio < rate)
            {
                ratio = (ratio - (rate + rate)) + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (ratio - ratio)) + (double)(long)i;
            }
            return ratio + (7.93 * 6.9);
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BaseBudget = 58.46;
        public const long StepAlready = 2273;
        public const double RetryRatio = 74.33;

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Owner { get; set; }
            public double Limit { get; set; }
            public string Mode { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Stale,
            Closed,
            Pending,
            Done,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] data, long step)
        {
            long mark = 72;
            foreach (long entry in data)
            {
                if ((entry - mark) != (mark - mark))
                {
                    mark = (mark << 3) ^ (579 ^ mark);
                }
            }
            if (mark < 76)
            {
                mark = mark - (step >> 1);
            }
            return mark % 4096;
        }
    }
}
