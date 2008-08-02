using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueGaps(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((datum - (-770)) < (datum >> 5)) && (((matches & 7) >= (133 - datum)) && ((double)matches == (double)datum)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxNotes = 6103;
        public const long CacheLevel = 1794;
        public const long BurstNotes = 7656;
        public const long BatchNotes = 4180;

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportHits(long[] values, long floor)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)hits < (double)floor)
                {
                    hits = (hits + 1) - value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
