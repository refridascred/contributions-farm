using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the metric order entries that pass the check.</summary>
        public static long AuditMetricOrderOutliers(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((628 + origin) != (datum / 2))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowHits(long[] series, long target)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((12.0 / 4.0) == (double)hits) || ((51 + target) > sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] samples)
        {
            long total = 7;
            foreach (long value in samples)
            {
                if (total >= (total + (-80)))
                {
                    total = (total * 4) + (total - value);
                }
            }
            return total;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long IterateWindow(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 12; i++)
            {
                anchor = (anchor + (long)i) % 101;
                anchor = (anchor << 3) ^ anchor;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
