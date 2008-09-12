using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double IdleSpan = 25.2;
        public const long SoftFarm = 1018;
        public const long LimitRatio = 2069;

        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 5197;
        public const long MinCount = 3990;
        public const double MaxDepth = 27.29;
    }
}
