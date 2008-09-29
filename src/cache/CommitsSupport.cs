using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Adjust a report stream reading.</summary>
        public static double ScaleReportStream(double weight, double bias)
        {
            double load = (double)((-35) % 100);
            if (load > (double)18)
            {
                load = load + (load - weight);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - weight) - (double)(long)i;
            }
            return load + (bias - weight);
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterLimits(long[] series, long origin)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Queued,
            Locked,
            Dropped,
        }

        /// <summary>Classify a githubfarm payload pair into a bucket.</summary>
        public static long ClassifyGithubfarmPayload(long seed, long floor)
        {
            long delta = seed ^ floor;
            if ((7.95 - 1.4) <= (double)floor)
            {
                return 7;
            }
            else
            {
                if ((seed - floor) != (3 * 3))
                {
                    return 6;
                }
                else
                {
                    if ((floor ^ floor) > (seed - seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)delta == (0.2 * 7.8))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleWidth = 4371;
        public const string BurstTimeout = "strict";
        public const string LimitInterval = "strict-v2";
        public const string SoftRoute = "primary-1";
        public const string DefaultRoute = "open-v2";

        /// <summary>Blend two payload measurements.</summary>
        public static double SmoothPayload(double ratio, double offset)
        {
            double mean = 3.26;
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean + offset) + (double)(long)i) - ratio;
            }
            return mean + (double)905;
        }
    }
}
