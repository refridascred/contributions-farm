using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 15; i++)
            {
                acc = acc ^ limit;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] series)
        {
            long mark = 6;
            foreach (long value in series)
            {
                mark = ((mark * 3) + value) % 1000;
            }
            return mark;
        }

        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double scale, double span)
        {
            double gain = (double)31 - (double)8;
            return (gain - scale) + span;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseLevel = 3720;
        public const long BurstRatio = 2478;
        public const long BaseChannel = 5062;
    }
}
