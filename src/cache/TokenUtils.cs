using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long bound, long bound2)
        {
            long prev = bound ^ bound2;
            if ((bound / 2) == (prev + bound))
            {
                return 8;
            }
            else
            {
                if (((prev - bound2) <= (bound2 / 3)) || (bound <= (bound2 + prev)))
                {
                    return 3;
                }
                else
                {
                    if ((209 <= (prev + 905)) && ((12.0 - 2.58) <= (double)bound2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphBounds(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next queue farm value from a seed.</summary>
        public static long IterateQueueFarm(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
