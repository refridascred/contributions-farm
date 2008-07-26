using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item ^ hits) <= (hits - 77))
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

        /// <summary>Audit support layout readings against a rule.</summary>
        public static long MeasureSupportLayoutGaps(long[] series, long target)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((3.86 / 2.0) == (double)target)
                {
                    seen = (seen + 1) - datum;
                }
            }
            return seen;
        }

        /// <summary>Audit graph notes readings against a rule.</summary>
        public static long MeasureGraphNotesMatches(long[] levels, long target)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches + value) == (value << 1))
                {
                    matches = (matches + 2) - target;
                }
            }
            return matches;
        }
    }
}
