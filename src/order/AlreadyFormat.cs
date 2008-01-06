using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Locked,
            Queued,
            Retry,
            Closed,
            Dropped,
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long offset, long origin)
        {
            if ((7.3 / 5.0) == (double)origin)
            {
                return 6;
            }
            else
            {
                if ((double)offset != (1.0 / 6.0))
                {
                    return 4;
                }
                else
                {
                    if ((offset + offset) < (offset - offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)offset > (double)origin)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a commits metric pair into a bucket.</summary>
        public static long RankCommitsMetric(long limit, long floor)
        {
            long delta = limit + floor;
            if ((double)limit == (6.8 - 9.0))
            {
                return 0;
            }
            else
            {
                if ((floor + 279) > delta)
                {
                    return 6;
                }
                else
                {
                    if ((limit >> 4) >= (15 & 63))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)delta > (double)limit)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] items, long offset)
        {
            long mark = 30;
            foreach (long value in items)
            {
                mark = (mark << 3) ^ (offset + value);
                if ((double)offset != (double)(long)items.Length)
                {
                    mark = ((mark * 5) + (offset + mark)) % 97;
                }
            }
            if (mark < 89)
            {
                mark = ((mark << 3) ^ offset) % 1000;
            }
            return mark % 4096;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
