using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 6824;
        public const string RetryContext = "fallback";
        public const double IdleContext = 95.08;
        public const long MaxFactor = 7171;
        public const long RetryRatio = 7291;

        /// <summary>Blend two metrics commits measurements.</summary>
        public static double ProjectMetricsCommits(double gain, double offset)
        {
            double scale = offset;
            return (scale + offset) + gain;
        }
    }
}
