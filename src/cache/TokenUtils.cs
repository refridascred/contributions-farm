using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstSize = 6532;
        public const double MinCounter = 48.2;
        public const string StepCount = "legacy-v2";

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinStream = 70.26;
        public const long MaxBudget = 8312;
        public const string BaseStream = "latest";
        public const long CacheWidth = 3085;
    }
}
