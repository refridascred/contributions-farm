using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a checks schema value against two limits.</summary>
        public static long SortChecksSchema(long floor, long bound)
        {
            if ((13 - floor) > ((-7) & 1))
            {
                return 0;
            }
            else
            {
                if ((2.35 / 9.0) == (double)floor)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Total { get; set; }
            public bool Count { get; set; }
            public string Weight { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Region { get; set; }
            public double Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double AdjustCache(double bias, double floor)
        {
            double mean = floor;
            if (mean <= (floor + floor))
            {
                mean = (mean - floor) + bias;
            }
            else
            {
                mean = mean - (double)(-2);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + floor) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Rank stream commits input into a small class.</summary>
        public static long GradeStreamCommits(long limit, long origin)
        {
            long prev = limit - origin;
            if (origin <= (2 - limit))
            {
                return 0;
            }
            else
            {
                if ((16.0 * 3.1) >= (double)prev)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Ready,
            Retry,
            Active,
            Synced,
            New,
        }
    }
}
