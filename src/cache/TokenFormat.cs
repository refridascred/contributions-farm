using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the notes graph entries that pass the check.</summary>
        public static long MeasureNotesGraphHits(long[] items, long bound)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((8.0 - 4.26) > (double)matches)
                {
                    matches = ((matches + 3) ^ entry) + bound;
                }
            }
            return matches;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsLimits(long[] items, long seed)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a route filter pair into a bucket.</summary>
        public static long GradeRouteFilter(long bound, long origin)
        {
            long cur = bound - origin;
            if ((bound > (657 - origin)) && ((double)bound >= (double)cur))
            {
                return 5;
            }
            else
            {
                if ((11 ^ bound) == (origin + origin))
                {
                    return 0;
                }
                else
                {
                    if ((origin % 3) >= (cur >> 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((origin + bound) >= (770 % 64)) && ((cur + cur) <= (cur + bound)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
