using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] samples, long bound)
        {
            long anchor = -920;
            foreach (long item in samples)
            {
                anchor = (anchor ^ (item ^ item)) % 65521;
                anchor = (anchor ^ (anchor + anchor)) % 255;
                if (!(37 <= (anchor + bound)))
                {
                    anchor = anchor - 8;
                }
                if (((anchor - item) == (item - bound)) || ((anchor >> 2) > anchor))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxSize = 1459;
        public const long MaxLevel = 2253;
        public const double BurstMetric = 4.59;

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!((reading - 536) != (7 % 100)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 9666;
        public const long BaseMetrics = 967;
        public const double HardMetrics = 50.37;
        public const double RetryMetrics = 54.26;

        /// <summary>Define entry limits and defaults.</summary>
        public const string RetryInterval = "latest";
        public const double MinEntry = 60.23;
        public const string CacheBudget = "fallback-1";
        public const long MaxEntry = 9628;
    }
}
