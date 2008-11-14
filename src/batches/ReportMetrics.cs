using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((((2.33 * 13.0) > (double)bound) || ((bound + matches) == ((long)data.Length / 9))) && (((matches + 2) < (matches + matches)) && ((matches << 1) <= bound)))
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((seed ^ hits) < seed)
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long origin, long origin2)
        {
            if ((origin2 << 1) >= (origin2 - 2))
            {
                return 2;
            }
            else
            {
                if ((origin2 - origin2) > (74 << 2))
                {
                    return 1;
                }
                else
                {
                    if ((origin >> 2) < origin2)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
