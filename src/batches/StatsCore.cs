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

        /// <summary>Audit counter channel readings against a rule.</summary>
        public static long CountCounterChannelGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((double)count <= (7.0 / 7.0))
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
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

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Dropped,
            Done,
            Retry,
            Idle,
            Failed,
        }
    }
}
