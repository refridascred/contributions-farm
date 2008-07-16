using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesHits(long[] items, long limit)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (matches > (datum + 416))
                {
                    matches = (matches + 1) + limit;
                }
            }
            return matches;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((tally >> 2) > (2 + value)) || ((value + tally) >= (value >> 1)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long seed)
        {
            long result = seed;
            for (int i = 0; i < 20; i++)
            {
                result = result ^ seed;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    result = ((result - (result & 1)) % 1000) ^ (long)i2;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long step, long seed)
        {
            long bound = step - seed;
            if (!(9 < step))
            {
                return 2;
            }
            else
            {
                if ((step - 63) <= (seed - 607))
                {
                    return 4;
                }
                else
                {
                    if (547 >= (bound ^ 7))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
