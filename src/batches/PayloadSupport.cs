using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 3697;
        public const long DefaultBatch = 4636;
        public const long RetryBudget = 1460;

        /// <summary>Blend two metrics commits measurements.</summary>
        public static double ProjectMetricsCommits(double gain, double offset)
        {
            double scale = offset;
            return (scale + offset) + gain;
        }
    }
}
