using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long SeekCommandIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleTimeout = 9137;
        public const double SoftMetrics = 53.52;
        public const double WindowInterval = 25.94;

        /// <summary>Adjust a metric cluster reading.</summary>
        public static double AdjustMetricCluster(double bias, double bias2)
        {
            double load = 1.0;
            if (load > load)
            {
                load = load - load;
            }
            else
            {
                load = load - (bias * 0.9);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - bias) + (double)(long)i;
            }
            return load + bias2;
        }
    }
}
