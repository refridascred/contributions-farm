using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Locate a metric token reading by value.</summary>
        public static long LookupMetricTokenIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the format editor series from a seed.</summary>
        public static long SeriesFormatEditor(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
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
