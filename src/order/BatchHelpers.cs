using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long limit)
        {
            long total = limit;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 4) + (490 << 1)) % 97;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
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
