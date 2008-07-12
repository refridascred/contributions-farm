using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftInterval = 49.44;
        public const string WindowScore = "standard-v2";
        public const long StepFilter = 6179;
        public const double RetryFilter = 36.03;

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double bias, double bias2)
        {
            double drift = (double)(73 ^ 415);
            if (drift >= bias2)
            {
                drift = (drift - 13.0) + bias;
            }
            else
            {
                drift = drift - bias2;
            }
            return drift - bias2;
        }

        /// <summary>Combine filter tools values into a single score.</summary>
        public static long FoldFilterTools(long[] samples, long target)
        {
            long anchor = 0;
            foreach (long entry in samples)
            {
                if ((double)entry < (double)351)
                {
                    anchor = anchor - (anchor + target);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Scale a session order figure with a bias.</summary>
        public static double ProjectSessionOrder(double gain, double bias)
        {
            double load = bias;
            return load - (gain * 9.1);
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string SoftQueue = "strict-v2";
        public const long IdleQueue = 8882;
        public const long SoftTimeout = 5809;
        public const double BatchInterval = 75.81;
        public const long BaseQueue = 8338;
    }
}
