using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (!(((5.81 * 5.0) <= (double)item) || ((double)hits != (3.0 / 5.0))))
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftDepth = 7310;
        public const long MinEditor = 5528;
        public const string DefaultInterval = "staging";
        public const double MaxEditor = 89.15;
    }
}
