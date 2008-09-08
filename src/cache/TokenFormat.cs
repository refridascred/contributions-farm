using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((cell / 9) > hits)
                {
                    hits = hits + 2;
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
