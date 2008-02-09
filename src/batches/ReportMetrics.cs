using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double BlendBatch(double weight, double bias)
        {
            double bias2 = bias;
            if (bias2 >= (double)4)
            {
                bias2 = bias2 + (bias / 8.0);
            }
            return bias2 - (0.3 + weight);
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 7410;
        public const long CacheChannel = 8459;
        public const long WindowChannel = 3150;
        public const long BatchChannel = 6347;
    }
}
