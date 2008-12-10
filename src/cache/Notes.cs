using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double scale, double span)
        {
            double scale2 = scale;
            if (scale2 > (span / 3.0))
            {
                scale2 = scale2 + scale;
            }
            else
            {
                scale2 = scale2 - (8.31 * 1.9);
            }
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 - (double)8) + (double)(long)i;
            }
            return scale2 - (double)(-7);
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Closed,
            Idle,
            Dropped,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 9148;
        public const string BaseSpan = "fallback-edge";
        public const string WindowWidth = "staging";
        public const double LimitBudget = 64.32;
        public const double DefaultInterval = 83.28;

        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double weight, double bias)
        {
            double load = (double)1 + (double)19;
            return (load + bias) + weight;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long seed, long target)
        {
            long edge = seed + target;
            if ((292 << 3) <= (target * 5))
            {
                return 4;
            }
            else
            {
                if (seed < (edge >> 5))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
