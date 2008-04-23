using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double rate, double bias)
        {
            double rate2 = 6.4 - (rate / 2.0);
            if (rate2 < (bias - 5.69))
            {
                rate2 = rate2 - rate2;
            }
            return rate2 + (rate2 + bias);
        }

        /// <summary>Derive the next support metrics value from a seed.</summary>
        public static long DeriveSupportMetrics(long limit)
        {
            long state = limit;
            for (int i = 0; i < 4; i++)
            {
                state = (state * 5) + (limit * 5);
                for (int i2 = 0; i2 < 2; i2++)
                {
                    state = ((state + 393) % 4096) + (long)i2;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
