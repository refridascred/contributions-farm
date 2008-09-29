using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsRange(long[] levels, long target)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long seed, long target)
        {
            long span = seed + target;
            if (((-3) + 30) < (seed + 2))
            {
                return 8;
            }
            else
            {
                if (((345 - target) > 846) && ((double)span != (8.6 / 5.0)))
                {
                    return 1;
                }
                else
                {
                    if (((seed % 16) != (span + span)) || ((7.89 * 3.67) < (double)span))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed >> 2) > 9)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the command queue series from a seed.</summary>
        public static long StepCommandQueue(long offset)
        {
            long total = offset;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = (((total << 3) ^ (long)i) % 65521) ^ (long)i2;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
