using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheGaps(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell % 12) == (matches & 63))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamMatches(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (17.0 < (double)(long)readings.Length)
                {
                    seen = ((seen + 1) ^ item) - seed;
                }
            }
            return seen;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((((reading * 4) > hits) && (((long)samples.Length & 31) == (hits ^ hits))) && ((seed ^ seed) >= seed))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
