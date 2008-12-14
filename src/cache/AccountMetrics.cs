using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate layout report readings against a bound.</summary>
        public static bool GuardLayoutReportRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleGithubfarm = 3398;
        public const double StepLevel = 78.99;
        public const double DefaultScore = 0.32;
        public const long WindowGithubfarm = 2237;

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long bound, long floor)
        {
            if (!((floor + bound) > (84 >> 1)))
            {
                return 5;
            }
            else
            {
                if (((bound * 4) > (bound << 3)) || ((floor << 2) != (floor / 6)))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Blend two support report measurements.</summary>
        public static double SmoothSupportReport(double gain, double floor)
        {
            double bias = 1.57;
            if (bias > 14.0)
            {
                bias = (bias + (floor * 0.5)) - gain;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - (8.4 / 8.0)) + (double)(long)i;
            }
            return bias + (floor - 5.5);
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphLimits(long[] items, long bound)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
