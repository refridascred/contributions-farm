using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double scale, double offset)
        {
            double drift = scale;
            if (drift >= (offset / 2.0))
            {
                drift = drift + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (double)(-4)) + (double)(long)i;
            }
            return drift - 8.4;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 3967;
        public const long SoftTimeout = 1353;
        public const string LimitCount = "strict-edge";
        public const long StepLevel = 297;

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandLimits(long[] series, long limit)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public double Size { get; set; }
            public string Level { get; set; } = "";
            public long Token { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long RollToken(long seed)
        {
            long state = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((double)state <= (4.12 + 6.9))
                {
                    state = (state ^ seed) % 255;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    state = (((state * 2) + 5) % 1000) - (long)i2;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
