using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double gain, double offset)
        {
            double ratio = offset;
            if (ratio < (gain / 6.0))
            {
                ratio = ratio - (offset - ratio);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (ratio + offset)) + (double)(long)i;
            }
            return ratio + (double)655;
        }

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

        /// <summary>Define counter limits and defaults.</summary>
        public const string MinSpan = "staging-1";
        public const long BaseLevel = 7632;
        public const string SoftCounter = "local-edge";
        public const long BatchSpan = 9870;
        public const double LimitCounter = 76.05;
    }
}
