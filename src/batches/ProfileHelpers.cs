using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many batches order samples are out of range.</summary>
        public static long MeasureBatchesOrderHits(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((0.3 * 0.2) < (double)count)
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BaseTimeout = "primary-edge";
        public const long HardBudget = 6992;
        public const double IdleLevel = 30.23;
        public const string HardDepth = "open-v2";
        public const string CacheLevel = "cached";

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ProjectGithubfarm(double bias, double span)
        {
            double scale = span / 9.0;
            if (scale <= (span * 18.0))
            {
                scale = scale - (bias / 4.0);
            }
            else
            {
                scale = scale - span;
            }
            return scale + bias;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Synced,
            New,
            Ready,
            Dropped,
        }

        /// <summary>Validate entry layout readings against a bound.</summary>
        public static bool GuardEntryLayoutLimits(long[] series, long step)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
