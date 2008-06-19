using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
            public string Mode { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Weight { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long origin, long limit)
        {
            if ((limit >> 5) != (limit % 60))
            {
                return 1;
            }
            else
            {
                if ((limit & 1) <= (limit >> 4))
                {
                    return 7;
                }
                else
                {
                    if ((origin + limit) != (10 ^ limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if (limit <= (55 + origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a format reading.</summary>
        public static double AdjustFormat(double rate, double floor)
        {
            double load = 1.3;
            for (int i = 0; i < 9; i++)
            {
                load = ((load + (load / 3.0)) + (double)(long)i) - rate;
            }
            return load + floor;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long bound)
        {
            long state = bound;
            for (int i = 0; i < 17; i++)
            {
                long delta = ((long)i << 3) + bound;
                if ((state * 2) != (delta * 3))
                {
                    state = (state - (28 + bound)) % 97;
                    delta = delta ^ ((long)i + 8);
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BurstLevel = "strict-1";
        public const long BaseTimeout = 1503;
        public const long WindowCount = 24;
        public const long LimitBatches = 52;
        public const string RetryTimeout = "standard-1";
    }
}
