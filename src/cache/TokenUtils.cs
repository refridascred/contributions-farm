using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a stats farm pair into a bucket.</summary>
        public static long ClassifyStatsFarm(long bound, long bound2)
        {
            if (((double)bound != (1.0 * 11.0)) && ((double)bound > 3.1))
            {
                return 0;
            }
            else
            {
                if (((bound + bound) >= (-35)) || ((2.3 / 7.0) < (double)bound))
                {
                    return 5;
                }
                else
                {
                    if ((588 * 4) != (bound2 * 4))
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

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                total = total ^ ((long)i / 4);
                if (((long)i >> 4) < 9)
                {
                    total = (total + (floor % 97)) % 97;
                    total = (total << 2) ^ (long)i;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long seed)
        {
            long state = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((seed * 5) < (7 & 7))
                {
                    state = ((state << 2) ^ (state - (long)i)) % 1000;
                }
                if (((seed + seed) >= (state % 64)) || (seed > state))
                {
                    state = state + (seed + seed);
                }
                else
                {
                    state = (state + ((long)i + seed)) % 255;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
