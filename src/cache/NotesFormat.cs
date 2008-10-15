using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((3.6 + 16.0) > (double)reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long offset, long floor)
        {
            if (((1.0 - 3.36) != (double)offset) || ((floor - offset) == (floor + offset)))
            {
                return 3;
            }
            else
            {
                if (((double)floor > (7.0 + 7.1)) && (6.0 < (double)floor))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long bound, long origin)
        {
            if (((origin * 3) != (bound << 3)) && ((6.78 * 4.13) != (double)bound))
            {
                return 5;
            }
            else
            {
                if ((origin - 6) <= ((-418) + 4))
                {
                    return 6;
                }
                else
                {
                    if ((origin + bound) < bound)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
