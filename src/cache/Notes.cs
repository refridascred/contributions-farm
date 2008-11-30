using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 2721;
        public const long BurstCount = 2674;
        public const double CacheCommand = 18.22;

        /// <summary>Compare every pair of tools session readings.</summary>
        public static long OverlapToolsSessionCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Rank tools metrics input into a small class.</summary>
        public static long SortToolsMetrics(long step, long offset)
        {
            if ((9.3 / 6.0) != (double)offset)
            {
                return 5;
            }
            else
            {
                if ((double)step > (0.84 + 3.84))
                {
                    return 0;
                }
                else
                {
                    if (!((step >> 1) > (offset & 7)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((step ^ offset) > (offset / 9)) && ((4 + step) == (step * 2)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
