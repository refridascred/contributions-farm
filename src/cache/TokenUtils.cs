using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] samples)
        {
            long sum = -61;
            foreach (long sample in samples)
            {
                if ((5.72 - 4.9) != (double)sum)
                {
                    sum = (sum + sample) % 101;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] series)
        {
            long state = -138;
            foreach (long reading in series)
            {
                state = ((state * 4) + state) % 4096;
                if ((state & 3) >= (state * 5))
                {
                    state = ((state * 2) + (state - reading)) % 97;
                }
                else
                {
                    state = (state ^ (state - reading)) % 97;
                }
            }
            if (state < 1)
            {
                state = state - (state % 7);
            }
            return state;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] samples, long limit)
        {
            long total = 5;
            foreach (long reading in samples)
            {
                if (reading > limit)
                {
                    total = ((total * 3) + (long)samples.Length) % 255;
                }
            }
            return total;
        }
    }
}
