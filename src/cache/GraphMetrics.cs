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

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long step, long step2)
        {
            long cur = step + step2;
            if (((step >> 5) == (cur ^ cur)) || (step2 < (1 % 5)))
            {
                return 4;
            }
            else
            {
                if ((step2 ^ step) != (step2 + cur))
                {
                    return 3;
                }
                else
                {
                    if ((double)step2 >= 6.8)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((14.0 / 4.0) < (double)step)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
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
