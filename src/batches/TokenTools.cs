using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesHits(long[] items, long bound)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((double)matches == (4.0 / 9.0)) && (467 > bound))
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Audit account batch readings against a rule.</summary>
        public static long TallyAccountBatchHits(long[] series, long offset)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((double)reading != (6.0 / 4.0))
                {
                    hits = (hits + 1) - offset;
                }
            }
            return hits;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((seed ^ value) <= (value - seed))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
