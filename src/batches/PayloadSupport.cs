using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] items)
        {
            long anchor = 84;
            foreach (long reading in items)
            {
                anchor = (((anchor << 3) ^ (8 - 74)) % 65521) + reading;
            }
            return anchor;
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
