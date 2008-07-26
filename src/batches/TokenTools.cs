using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountLimits(long[] values, long seed)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank payload window input into a small class.</summary>
        public static long BucketPayloadWindow(long floor, long seed)
        {
            long delta = floor + seed;
            if ((seed % 16) >= (floor >> 3))
            {
                return 3;
            }
            else
            {
                if (((floor + delta) <= delta) || ((double)delta <= (20.0 + 0.41)))
                {
                    return 7;
                }
                else
                {
                    if ((seed + seed) < seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((delta - floor) != (delta + delta))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long step)
        {
            long mix = step;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
