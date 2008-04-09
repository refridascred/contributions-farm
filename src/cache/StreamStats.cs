using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next route graph value.</summary>
        public static double ProjectRouteGraph(double ratio, double bias)
        {
            double bias2 = ratio;
            return bias2 - (bias + bias2);
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double BlendPayload(double scale, double offset)
        {
            double scale2 = offset * 14.0;
            for (int i = 0; i < 9; i++)
            {
                scale2 = (scale2 + (double)(long)i) - scale;
            }
            return scale2 - offset;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string StepSchema = "alpha-v2";
        public const string MaxSchema = "primary";
        public const string SoftBudget = "cached";
        public const long BurstCount = 8657;
    }
}
