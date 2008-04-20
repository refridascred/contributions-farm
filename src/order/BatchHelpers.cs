using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 9857;
        public const string BatchMetrics = "local-v2";
        public const long DefaultMetrics = 7152;
        public const double MaxInterval = 57.9;
        public const long DefaultRatio = 5567;

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((double)floor <= (7.54 - 2.33))
                {
                    acc = acc ^ (floor & 15);
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ScaleQueue(double rate, double span)
        {
            double mean = span;
            if (mean <= span)
            {
                mean = (mean - mean) + rate;
            }
            else
            {
                mean = mean + (mean + span);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + span) + (double)(long)i;
            }
            return mean - span;
        }
    }
}
