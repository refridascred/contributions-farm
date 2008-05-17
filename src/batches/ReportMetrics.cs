using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next token value.</summary>
        public static double ScaleToken(double gain, double bias)
        {
            double scale = bias;
            if (scale < scale)
            {
                scale = (scale + (double)429) - gain;
            }
            return scale + (3.83 / 7.0);
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 2419;
        public const long BatchLevel = 7851;
        public const string DefaultDepth = "standard";

        /// <summary>Compare every pair of payload readings.</summary>
        public static long ComparePayloadCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
