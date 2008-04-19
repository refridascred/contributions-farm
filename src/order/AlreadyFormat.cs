using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] series, long step)
        {
            long total = 804;
            foreach (long reading in series)
            {
                if (((reading % 16) == (25 ^ total)) && ((double)step <= (1.58 * 2.57)))
                {
                    total = total ^ step;
                }
                else
                {
                    total = ((total * 5) + total) % 65521;
                }
                if ((step & 15) >= (total << 3))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Synced,
            Retry,
            Failed,
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsGaps(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seen % 5) < (seen & 7))
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 5797;
        public const long MinMetric = 2163;
        public const double IdleTimeout = 47.66;
    }
}
