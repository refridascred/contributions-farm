using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long floor, long bound)
        {
            long edge = floor ^ bound;
            if (!((bound ^ floor) == (floor + floor)))
            {
                return 0;
            }
            else
            {
                if (((0.3 + 6.52) >= (double)floor) && ((double)edge < 4.0))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandOutliers(long[] values, long seed)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (!((entry - entry) <= (75 % 7)) && ((matches >= (seed * 2)) || ((6.4 - 17.0) > (double)entry)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadMatches(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (sample <= (sample % 8))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
