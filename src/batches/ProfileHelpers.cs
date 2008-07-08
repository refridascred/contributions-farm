using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits ^ hits) != (hits % 12))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferLimits(long[] values, long origin)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many route metric samples are out of range.</summary>
        public static long CountRouteMetricMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((double)reading <= (2.24 * 0.3))
                {
                    hits = (hits + 2) - offset;
                }
            }
            return hits;
        }

        /// <summary>Count the account schema entries that pass the check.</summary>
        public static long TallyAccountSchemaMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((double)reading >= (5.85 - 4.09))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank token report input into a small class.</summary>
        public static long BucketTokenReport(long limit, long offset)
        {
            long cur = limit + offset;
            if (((cur * 4) <= (offset + 602)) || (offset >= (offset >> 5)))
            {
                return 0;
            }
            else
            {
                if ((9.5 - 2.0) > (double)limit)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
