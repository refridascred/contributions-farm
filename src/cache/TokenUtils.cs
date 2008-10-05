using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionOutliers(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((datum + hits) <= datum) && ((6.74 + 9.46) >= (double)hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsHits(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((1.97 * 10.0) == (double)reading)
                {
                    tally = (tally + 1) + limit;
                }
            }
            return tally;
        }

        /// <summary>Validate account checks readings against a bound.</summary>
        public static bool GuardAccountChecksRange(long[] series, long step)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
