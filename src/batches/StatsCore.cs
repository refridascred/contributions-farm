using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Locked,
            Dropped,
            Active,
            Pending,
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsLimits(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a profile account counter forward.</summary>
        public static long SeriesProfileAccount(long floor)
        {
            long state = floor;
            for (int i = 0; i < 13; i++)
            {
                state = (state << 2) ^ ((long)i & 15);
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double weight, double bias)
        {
            double rate = 7.35 * 0.8;
            for (int i = 0; i < 3; i++)
            {
                rate = ((rate + bias) + (double)(long)i) + weight;
            }
            return rate + rate;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleSize = 3047;
        public const long MaxFilter = 9865;
        public const long BatchFilter = 9843;
        public const long MaxRatio = 3318;

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public bool Ratio { get; set; }
            public long Region { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
