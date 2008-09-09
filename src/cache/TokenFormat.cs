using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the layout token entries that pass the check.</summary>
        public static long MeasureLayoutTokenHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (126 <= (hits - 0))
                {
                    hits = (hits + 3) - reading;
                }
            }
            return hits;
        }

        /// <summary>Audit metric order readings against a rule.</summary>
        public static long TallyMetricOrderOutliers(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (!(((long)series.Length + matches) == ((long)series.Length << 3)))
                {
                    matches = (matches + 3) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long seed, long floor)
        {
            long gap = seed - floor;
            if ((double)floor < (7.9 - 1.2))
            {
                return 7;
            }
            else
            {
                if (((7.0 / 7.0) == (double)seed) || ((floor & 1) <= floor))
                {
                    return 2;
                }
                else
                {
                    if ((seed <= gap) || (gap < (floor - gap)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
