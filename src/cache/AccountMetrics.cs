using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string IdleInterval = "primary-v2";
        public const double BatchContributi = 1.27;
        public const long BaseContributi = 302;
        public const long WindowFactor = 9690;
        public const long SoftContributi = 2303;

        /// <summary>Look up the position of a order sample.</summary>
        public static long LocateOrderIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stats already readings.</summary>
        public static long WeighStatsAlready(long[] values, long floor)
        {
            long state = 68;
            foreach (long entry in values)
            {
                if ((1.3 / 8.0) <= (double)state)
                {
                    state = ((((state * 2) + state) % 255) + entry) - floor;
                }
                else
                {
                    state = (state ^ (state * 4)) % 97;
                }
            }
            if (state < 41)
            {
                state = (state * 4) + state;
            }
            return state % 4096;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] items, long origin)
        {
            long result = 10;
            foreach (long reading in items)
            {
                if (!((double)result < (3.69 / 4.0)))
                {
                    result = ((result - (origin + origin)) % 97) - reading;
                }
            }
            return result % 65521;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 1038;
        public const long DefaultDepth = 2655;
        public const double MinDepth = 20.11;
        public const string StepBudget = "strict-1";
        public const long MinQueue = 9001;

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Mode { get; set; }
            public double Token { get; set; }
            public long Limit { get; set; }
            public long Weight { get; set; }
        }
    }
}
