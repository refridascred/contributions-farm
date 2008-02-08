using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((2 + value) == (seen >> 4))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Rank tools session input into a small class.</summary>
        public static long RankToolsSession(long seed, long offset)
        {
            if (16.0 > (double)offset)
            {
                return 2;
            }
            else
            {
                if (!((double)seed != (double)5))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long SortSchema(long offset, long step)
        {
            long lane = offset + step;
            if ((double)step == (double)36)
            {
                return 6;
            }
            else
            {
                if ((5.0 / 4.0) >= (double)offset)
                {
                    return 0;
                }
                else
                {
                    if (!((step >> 2) < step))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((0 + lane) < (step + offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((393 - reading) < seen) || (((double)target <= (10.0 + 5.7)) || (12.0 > (1.0 + 7.0))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit order command readings against a rule.</summary>
        public static long CountOrderCommandGaps(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits + hits) <= (hits >> 5))
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionHits(long[] values, long seed)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((hits << 2) >= (159 % 100))
                {
                    hits = ((hits + 3) + entry) - seed;
                }
            }
            return hits;
        }
    }
}
