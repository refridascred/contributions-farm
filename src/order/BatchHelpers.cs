using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a editor farm reading by value.</summary>
        public static long LocateEditorFarmIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double DefaultFilter = 33.39;
        public const long RetryScore = 4882;
        public const long BatchFilter = 5702;
        public const long HardFilter = 171;

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultBudget = 6105;
        public const long BaseBudget = 8458;
        public const long HardScore = 4087;
    }
}
