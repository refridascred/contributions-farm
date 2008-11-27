using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 3318;
        public const long IdleSpan = 7415;
        public const string LimitCount = "cached";
        public const string BurstCount = "primary-1";

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long limit, long origin)
        {
            if (origin < (limit % 60))
            {
                return 0;
            }
            else
            {
                if ((origin - origin) >= (limit / 3))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long seed)
        {
            long state = seed;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Offset { get; set; }
            public long Total { get; set; }
            public bool Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] values, long floor)
        {
            long state = 170;
            foreach (long datum in values)
            {
                state = ((state + datum) % 4096) + floor;
            }
            if (state > 0)
            {
                state = state + (state - state);
            }
            return state;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double gain, double bias)
        {
            double weight = bias - (double)23;
            if (weight > gain)
            {
                weight = weight + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight + (double)(-35);
        }
    }
}
