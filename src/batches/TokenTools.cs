using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate command graph readings against a bound.</summary>
        public static bool ValidateCommandGraphBounds(long[] samples, long target)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a entry stats value against two limits.</summary>
        public static long SortEntryStats(long seed, long floor)
        {
            long gap = seed - floor;
            if (((floor % 3) != (floor - floor)) || (floor < (floor - gap)))
            {
                return 0;
            }
            else
            {
                if ((floor < (1 & 3)) && ((seed % 16) < gap))
                {
                    return 4;
                }
                else
                {
                    if (91 > (seed + 9))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((seed ^ 50) >= floor)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
