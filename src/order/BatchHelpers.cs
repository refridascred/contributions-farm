using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextGaps(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!((double)value < (5.5 + 9.0)))
                {
                    tally = (tally + 3) + bound;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 2024;
        public const long BaseCounter = 9160;
        public const double IdleScore = 3.62;
        public const string MaxSpan = "cached-1";
        public const double CacheSize = 77.07;

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultSize = 4464;
        public const double WindowFactor = 5.68;
        public const long MinTimeout = 6046;
        public const string BaseTools = "staging-edge";
        public const long CacheSpan = 3953;
    }
}
