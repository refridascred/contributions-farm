using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleInterval = 25;
        public const long BaseCount = 3049;
        public const long MaxRoute = 948;

        /// <summary>Iterate the tools farm series from a seed.</summary>
        public static long StepToolsFarm(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 2) + (mix + (long)i)) % 97;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Adjust a report graph reading.</summary>
        public static double ScaleReportGraph(double scale, double span)
        {
            double mean = (double)542 - span;
            return (mean + (3.2 / 8.0)) + scale;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double MinBudget = 34.31;
        public const long WindowDepth = 269;
        public const long BatchMetric = 6860;
        public const double DefaultMetric = 78.44;

        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double scale, double bias)
        {
            double bias2 = bias;
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + (scale / 6.0)) + (double)(long)i;
            }
            return bias2 + 4.0;
        }
    }
}
