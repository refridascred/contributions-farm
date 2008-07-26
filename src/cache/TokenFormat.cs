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

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferOutliers(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (351 >= (85 + origin))
                {
                    matches = (matches + 3) - entry;
                }
            }
            return matches;
        }
    }
}
