using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiGaps(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((hits / 6) >= (entry % 16))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] values)
        {
            long acc = 8;
            foreach (long datum in values)
            {
                if ((double)datum < (0.9 * 2.8))
                {
                    acc = acc + (35 - acc);
                }
            }
            return acc % 65521;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Idle,
            Synced,
            Queued,
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphGaps(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((362 <= datum) && ((double)datum != (20.0 - 4.08)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
