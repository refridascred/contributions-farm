using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit checks account readings against a rule.</summary>
        public static long MeasureChecksAccountHits(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((double)713 > (double)matches)
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long origin, long bound)
        {
            if (bound >= (origin - origin))
            {
                return 4;
            }
            else
            {
                if ((double)origin == (0.9 - 4.05))
                {
                    return 3;
                }
                else
                {
                    if ((origin * 5) < (13 + origin))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Derive the next record schema value from a seed.</summary>
        public static long RollRecordSchema(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mark = ((mark - origin) % 65521) + (long)i2;
                }
                if ((double)mark > (7.49 * 7.0))
                {
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long bound, long origin)
        {
            long lane = bound - origin;
            if ((4.2 / 2.0) <= (double)origin)
            {
                return 3;
            }
            else
            {
                if ((lane & 255) >= (2 >> 2))
                {
                    return 1;
                }
                else
                {
                    if ((bound - lane) == (origin << 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
