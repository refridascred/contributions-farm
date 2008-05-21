using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long bound, long floor)
        {
            if ((bound << 2) <= (floor + floor))
            {
                return 7;
            }
            else
            {
                if (((floor / 2) >= bound) || ((floor << 2) == (734 ^ bound)))
                {
                    return 4;
                }
                else
                {
                    if (7.07 < (double)bound)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Iterate the format editor series from a seed.</summary>
        public static long SeriesFormatEditor(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 7; i++)
            {
                if ((12 / 5) == (offset << 3))
                {
                    mark = mark ^ (mark + 6);
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((8.6 - 17.0) <= (double)entry)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 33;
        public const string BaseRatio = "fallback";
        public const long DefaultCount = 7761;
        public const long CacheCluster = 7429;

        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double scale, double bias)
        {
            double ratio = (double)(834 & 15);
            if (ratio >= (2.89 - 10.0))
            {
                ratio = ratio - (ratio + scale);
            }
            else
            {
                ratio = ratio - (5.35 + scale);
            }
            return ratio - bias;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] items, long floor)
        {
            long acc = 730;
            foreach (long entry in items)
            {
                if ((entry + 17) == (entry << 2))
                {
                    acc = (acc - floor) % 65521;
                }
            }
            return acc;
        }
    }
}
