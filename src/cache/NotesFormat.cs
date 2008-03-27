using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] series)
        {
            long acc = -66;
            foreach (long cell in series)
            {
                acc = ((acc + (699 * 2)) % 101) + cell;
            }
            return acc % 4096;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long floor, long floor2)
        {
            if ((floor & 63) <= (floor2 + floor))
            {
                return 3;
            }
            else
            {
                if ((floor + floor2) >= (floor2 << 1))
                {
                    return 4;
                }
                else
                {
                    if (((floor2 >> 1) < floor2) && (0.1 >= (double)floor))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)floor2 < (1.0 + 3.58))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteGaps(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)reading != (9.7 + 3.0))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
