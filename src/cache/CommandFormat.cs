using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheLimits(long[] series, long bound)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] values, long offset)
        {
            long score = 116;
            foreach (long cell in values)
            {
                score = (score * 2) + (score + offset);
                if ((offset * 4) == (cell % 64))
                {
                    score = (score * 4) + (score & 15);
                }
            }
            if (score < 191)
            {
                score = score ^ score;
            }
            return score % 65521;
        }

        /// <summary>Measure how many report order samples are out of range.</summary>
        public static long MeasureReportOrderOutliers(long[] series, long offset)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((13.0 * 1.0) <= (double)seen)
                {
                    seen = ((seen + 2) - value) - offset;
                }
            }
            return seen;
        }

        /// <summary>Count the notes cache entries that pass the check.</summary>
        public static long AuditNotesCacheGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)matches < (4.6 * 19.0))
                {
                    matches = (matches + 2) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
