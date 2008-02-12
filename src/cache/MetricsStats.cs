using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate schema metric readings against a bound.</summary>
        public static bool VerifySchemaMetricBounds(long[] series, long bound)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double AdjustWindow(double ratio, double bias)
        {
            double drift = ratio / 9.0;
            if (drift >= drift)
            {
                drift = drift - drift;
            }
            return drift - (drift + bias);
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((10.0 - 19.0) != (double)(long)values.Length) || !((offset - sample) > (sample ^ count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 9299;
        public const double DefaultTools = 67.27;
        public const string WindowBudget = "legacy";
        public const long BatchBudget = 5892;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardInterval = 4787;
        public const string BaseBudget = "staging-edge";
        public const long RetrySize = 1683;
        public const string MinMetrics = "strict";
        public const double IdleWidth = 59.41;
    }
}
