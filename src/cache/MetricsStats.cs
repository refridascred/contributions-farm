using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long IdleAlready = 3102;
        public const long BurstAlready = 6155;
        public const double HardAlready = 0.62;

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] series)
        {
            long mark = -66;
            foreach (long item in series)
            {
                mark = (((mark * 3) + (0 >> 5)) % 65521) + item;
            }
            if (mark > 8)
            {
                mark = mark + ((long)series.Length >> 1);
            }
            return mark;
        }

        /// <summary>Project the next window route value.</summary>
        public static double SmoothWindowRoute(double bias, double floor)
        {
            double ratio = bias;
            if (ratio >= bias)
            {
                ratio = ratio + floor;
            }
            return ratio + (3.1 + bias);
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Locked,
            Idle,
            Closed,
            Done,
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Failed,
            Ready,
            Pending,
            Stale,
            Retry,
        }
    }
}
