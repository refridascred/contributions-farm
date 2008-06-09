using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleRatio = 7691;
        public const long WindowTimeout = 2891;
        public const long BaseFarm = 7706;

        /// <summary>Adjust a command profile reading.</summary>
        public static double AdjustCommandProfile(double weight, double span)
        {
            double rate = 9.0;
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate + weight) - (double)(long)i) + span;
            }
            return rate - (double)91;
        }
    }
}
