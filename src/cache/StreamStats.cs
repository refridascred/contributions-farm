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

        /// <summary>Measure how many profile order samples are out of range.</summary>
        public static long MeasureProfileOrderGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample % 3) <= (matches + 6))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
