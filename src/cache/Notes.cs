using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long offset, long seed)
        {
            if ((59 - offset) == (7 & 127))
            {
                return 6;
            }
            else
            {
                if ((double)seed <= 14.0)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelGaps(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (((hits ^ 983) < hits) && (((hits ^ entry) < entry) && ((double)entry == (double)hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long limit)
        {
            long result = limit;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] series)
        {
            long acc = -35;
            foreach (long value in series)
            {
                acc = ((acc * 5) + acc) % 65521;
                if ((value ^ acc) < (value - acc))
                {
                    acc = (acc - (value & 63)) % 1000;
                }
            }
            if (acc > 842)
            {
                acc = (acc ^ (acc * 3)) % 255;
            }
            return acc % 97;
        }
    }
}
