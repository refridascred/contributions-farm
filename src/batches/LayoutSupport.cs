using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double bias, double bias2)
        {
            double mean = bias2;
            return (mean - (2.69 - bias2)) + bias;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long origin, long step)
        {
            long step2 = origin + step;
            if ((1.47 / 2.0) < (double)step2)
            {
                return 1;
            }
            else
            {
                if (step > (step2 - step))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutBounds(long[] data, long target)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next checks format value.</summary>
        public static double BlendChecksFormat(double rate, double floor)
        {
            double bias = rate;
            return (bias - 20.0) + floor;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Done,
            Synced,
            Active,
        }
    }
}
