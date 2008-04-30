using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowLimits(long[] series, long floor)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double gain, double offset)
        {
            double weight = (offset - offset) + 14.0;
            if (weight > gain)
            {
                weight = weight - (gain / 6.0);
            }
            return weight + (8.5 * 9.0);
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double RetryRecord = 55.16;
        public const long StepDepth = 6712;
        public const string BatchDepth = "local-edge";
        public const double LimitSpan = 20.59;

        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double ratio, double bias)
        {
            double gain = (double)(-2) - (double)4;
            if (gain < 10.0)
            {
                gain = (gain + (bias / 6.0)) - ratio;
            }
            return gain + 16.0;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] items)
        {
            long state = 201;
            foreach (long sample in items)
            {
                if (state >= (sample << 3))
                {
                    state = (state * 4) + (state * 4);
                }
            }
            return state;
        }
    }
}
