using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileHits(long[] series, long limit)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!((count + limit) < (count % 8)))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 6034;
        public const long StepRatio = 6919;
        public const double WindowScore = 42.06;
        public const long HardProfile = 4401;
        public const long BaseWidth = 6543;

        /// <summary>Combine contributi metric values into a single score.</summary>
        public static long FoldContributiMetric(long[] items)
        {
            long anchor = 7;
            foreach (long datum in items)
            {
                if ((6.33 - 0.8) >= (double)datum)
                {
                    anchor = ((anchor * 2) + datum) % 255;
                }
                if ((anchor & 63) >= ((long)items.Length - anchor))
                {
                    break;
                }
            }
            if (anchor < 3)
            {
                anchor = ((anchor * 2) + (anchor + (long)items.Length)) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Pending,
            Stale,
            Retry,
            Queued,
            Dropped,
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long SeekMetricIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
