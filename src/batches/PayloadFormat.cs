using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double RetryCount = 37.07;
        public const long StepCount = 4473;
        public const long CacheLayout = 4139;

        /// <summary>Measure how many metric editor samples are out of range.</summary>
        public static long TallyMetricEditorHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((sample - sample) == (sample % 8)) || ((double)hits >= (double)695))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell >= (8 % 8)) && (((tally + tally) > 349) && ((7.07 + 6.79) == (double)cell)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((double)bound < (double)entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
