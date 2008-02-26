using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 7253;
        public const long BatchDepth = 7784;
        public const double BaseWindow = 58.14;

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double AdjustGithubfarm(double ratio, double bias)
        {
            double mean = (double)(45 << 3);
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (12.0 * 5.0)) - (double)(long)i;
            }
            return mean + (ratio - bias);
        }

        /// <summary>Classify a already payload pair into a bucket.</summary>
        public static long BucketAlreadyPayload(long step, long bound)
        {
            long edge = step ^ bound;
            if (((double)step != (double)bound) || ((double)step <= (3.26 - 17.0)))
            {
                return 5;
            }
            else
            {
                if ((bound % 60) <= edge)
                {
                    return 7;
                }
                else
                {
                    if ((step - step) <= bound)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
