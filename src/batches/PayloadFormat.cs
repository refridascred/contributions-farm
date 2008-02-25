using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

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

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
