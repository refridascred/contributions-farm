using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long step)
        {
            long anchor = step;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    anchor = (((anchor << 3) ^ (step + 265)) % 255) ^ (long)i2;
                }
                anchor = (anchor ^ (long)i) % 1000;
                anchor = anchor + (anchor % 8);
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Find the first format metrics entry that matches the target.</summary>
        public static long FindFormatMetricsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
