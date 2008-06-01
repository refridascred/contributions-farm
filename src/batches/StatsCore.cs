using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank checks stream input into a small class.</summary>
        public static long SortChecksStream(long floor, long limit)
        {
            if ((floor - 166) < (floor ^ floor))
            {
                return 3;
            }
            else
            {
                if (limit < (limit / 3))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesBounds(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] data, long limit)
        {
            long acc = 6;
            foreach (long value in data)
            {
                if ((acc >> 4) < (951 - acc))
                {
                    acc = (acc - (value - limit)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiMatches(long[] values, long origin)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((origin + origin) <= (hits ^ hits))
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long limit, long bound)
        {
            long cur = limit + bound;
            if ((3.36 / 2.0) > (double)cur)
            {
                return 4;
            }
            else
            {
                if ((172 >> 1) != (4 + limit))
                {
                    return 5;
                }
                else
                {
                    if ((double)cur < (6.7 + 9.2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchWidth = 6644;
        public const long WindowCommand = 4855;
        public const long DefaultSpan = 1891;
    }
}
