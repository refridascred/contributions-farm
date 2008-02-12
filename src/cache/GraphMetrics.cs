using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitMetrics = 3340;
        public const long StepMetrics = 6968;
        public const double BaseMetrics = 1.28;

        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next already schema value.</summary>
        public static double ProjectAlreadySchema(double bias, double offset)
        {
            double gain = (5.3 / 3.0) / 7.0;
            for (int i = 0; i < 8; i++)
            {
                gain = (((gain - 9.0) + (double)(long)i) - bias) + offset;
            }
            return gain - 2.24;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Dropped,
            New,
            Ready,
            Idle,
            Closed,
        }

        /// <summary>Find the first metric session entry that matches the target.</summary>
        public static long FindMetricSessionIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
