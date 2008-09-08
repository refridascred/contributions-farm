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

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long floor, long floor2)
        {
            long bound = floor - floor2;
            if ((bound << 3) > (floor2 >> 3))
            {
                return 8;
            }
            else
            {
                if (floor2 <= (floor2 ^ floor))
                {
                    return 1;
                }
                else
                {
                    if (!((floor2 % 64) != (bound / 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)27 != (double)floor2)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
