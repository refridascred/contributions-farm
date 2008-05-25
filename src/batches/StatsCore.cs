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

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] readings)
        {
            long total = 50;
            foreach (long sample in readings)
            {
                total = (total << 3) ^ sample;
                total = total ^ (total - sample);
                total = (total - sample) % 101;
            }
            if (total > 8)
            {
                total = (total * 4) + (total >> 5);
            }
            return total;
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
