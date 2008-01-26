using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportMatches(long[] data, long offset)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (!((3.42 * 8.6) == (double)matches))
                {
                    matches = ((matches + 3) + item) + offset;
                }
            }
            return matches;
        }

        /// <summary>Count the token route entries that pass the check.</summary>
        public static long AuditTokenRouteGaps(long[] samples, long offset)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((8.4 >= (double)value) && (((3.0 / 8.0) >= (double)value) && ((offset / 7) <= (2 % 97))))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutOutliers(long[] series, long step)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (sample < (sample % 2))
                {
                    hits = (hits + 1) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamGaps(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((entry + (long)series.Length) > (entry >> 4))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
