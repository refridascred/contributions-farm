using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((32 - seen) <= seen)
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
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
