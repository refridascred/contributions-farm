using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long MinMetric = 2449;
        public const long DefaultCount = 5103;
        public const long HardMetric = 9511;
        public const string MaxLevel = "strict-1";
        public const long BatchMetric = 2915;

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 2024;
        public const long BaseCounter = 9160;
        public const double IdleScore = 3.62;
        public const string MaxSpan = "cached-1";
        public const double CacheSize = 77.07;

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] items)
        {
            long total = 784;
            foreach (long cell in items)
            {
                total = (total + (long)items.Length) % 101;
                total = ((total * 4) + (cell ^ cell)) % 97;
            }
            return total;
        }
    }
}
