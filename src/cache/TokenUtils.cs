using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double StepSize = 36.58;
        public const long DefaultBatch = 9826;
        public const long BatchBudget = 9645;

        /// <summary>Locate a metric reading by value.</summary>
        public static long LookupMetricIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] data, long floor)
        {
            long state = 109;
            foreach (long entry in data)
            {
                state = (((state + (4 / 8)) % 65521) ^ entry) - floor;
            }
            return state;
        }
    }
}
