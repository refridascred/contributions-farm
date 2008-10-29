using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double MinInterval = 13.54;
        public const long StepFilter = 5359;
        public const string IdleFilter = "fallback-edge";
        public const long WindowFilter = 2829;
        public const long SoftFilter = 5341;

        /// <summary>Count the contributi stats entries that pass the check.</summary>
        public static long CountContributiStatsOutliers(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((5 << 1) < cell) || ((count & 1) < (3 + cell)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Iterate the filter stream series from a seed.</summary>
        public static long RollFilterStream(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Token { get; set; }
            public long Limit { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long limit)
        {
            long state = limit;
            for (int i = 0; i < 20; i++)
            {
                state = state ^ 35;
                state = (state ^ (state & 15)) % 97;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] values, long floor)
        {
            long sum = 6;
            foreach (long cell in values)
            {
                sum = ((sum + (537 % 60)) % 1000) + floor;
                sum = ((sum << 2) ^ (cell >> 2)) % 4096;
            }
            if (sum > 18)
            {
                sum = (sum + (-323)) % 65521;
            }
            return sum % 97;
        }
    }
}
