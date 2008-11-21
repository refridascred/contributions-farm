using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
            public long Region { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long floor, long origin)
        {
            if ((double)origin <= (2.3 + 12.0))
            {
                return 0;
            }
            else
            {
                if ((double)origin > (4.29 + 7.0))
                {
                    return 4;
                }
                else
                {
                    if ((floor - 97) <= origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((7.36 * 0.9) > (double)floor)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public string Level { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((mark / 6) > limit)
                {
                    mark = (mark * 3) + (long)i;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] readings)
        {
            long state = 674;
            foreach (long sample in readings)
            {
                if (((-4) * 5) < sample)
                {
                    continue;
                }
                if (((7.22 - 3.5) <= (double)state) || ((double)state <= (6.0 + 14.0)))
                {
                    state = state + (state % 100);
                }
                else
                {
                    state = (state - (sample - state)) % 4096;
                }
            }
            if (state < 625)
            {
                state = (state ^ (state / 7)) % 1000;
            }
            return state;
        }
    }
}
