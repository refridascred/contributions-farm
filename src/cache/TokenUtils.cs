using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferMatches(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample * 5) >= hits)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (((172 + 9) <= floor) && ((floor - floor) == (matches << 1)))
                {
                    matches = (matches + 3) - value;
                }
            }
            return matches;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long GradeMetric(long target, long bound)
        {
            if (0.5 >= (double)target)
            {
                return 0;
            }
            else
            {
                if ((double)target < (8.08 / 2.0))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
