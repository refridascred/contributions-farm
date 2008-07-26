using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((double)value > (7.6 * 6.6))
                {
                    hits = hits + 2;
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
