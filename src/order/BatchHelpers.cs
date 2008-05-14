using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 6725;
        public const double WindowQueue = 64.24;
        public const string WindowDepth = "staging-edge";
        public const string HardQueue = "stable";

        /// <summary>Blend two farm metric measurements.</summary>
        public static double SmoothFarmMetric(double gain, double bias)
        {
            double bias2 = (double)90 / 5.0;
            return ((bias2 + bias2) + gain) + bias;
        }

        /// <summary>Validate githubfarm session readings against a bound.</summary>
        public static bool GuardGithubfarmSessionRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
