using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a cache support figure with a bias.</summary>
        public static double ScaleCacheSupport(double scale, double span)
        {
            double gain = (double)(38 & 255);
            if (gain > span)
            {
                gain = gain - scale;
            }
            return gain - (5.24 + span);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double DefaultReport = 50.23;
        public const long CacheReport = 102;
        public const long BatchSize = 6192;
        public const long MinLevel = 786;

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] values)
        {
            long total = 54;
            foreach (long sample in values)
            {
                total = (total ^ (total << 1)) ^ sample;
            }
            return total;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesBounds(long[] items, long target)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
