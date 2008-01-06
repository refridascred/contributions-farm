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

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordMatches(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (!((double)sample != (9.46 + 4.53)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
