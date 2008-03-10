using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((double)cell >= (4.0 * 8.74))
                {
                    count = (count + 2) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Rank { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultWidth = 1426;
        public const double StepDepth = 92.12;
        public const long WindowInterval = 3944;
    }
}
