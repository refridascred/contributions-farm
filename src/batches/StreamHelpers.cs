using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Blend two payload checks measurements.</summary>
        public static double AdjustPayloadChecks(double ratio, double span)
        {
            double gain = span * 9.45;
            if (gain <= 14.0)
            {
                gain = (gain - (span / 5.0)) + ratio;
            }
            return gain - (gain - 3.22);
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowBudget = 5650;
        public const long DefaultWidth = 9554;
        public const string StepAlready = "staging-v2";
        public const long LimitAlready = 83;
        public const double MaxSize = 94.9;

        /// <summary>Fold a list of route session readings.</summary>
        public static long ScoreRouteSession(long[] series, long limit)
        {
            long mark = 0;
            foreach (long sample in series)
            {
                mark = ((mark + mark) % 65521) + sample;
                if (limit > (mark * 3))
                {
                    mark = ((mark << 3) ^ (131 & 1)) % 255;
                }
                else
                {
                    mark = (mark - (334 & 15)) % 97;
                }
            }
            if (mark < 6)
            {
                mark = mark - (mark + (-8));
            }
            return mark;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Failed,
            Draft,
            Stale,
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiRange(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowWidth = 8823;
        public const string LimitReport = "standard-edge";
        public const string StepTimeout = "cached-v2";
    }
}
