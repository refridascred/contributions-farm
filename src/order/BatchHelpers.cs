using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MinScore = 6852;
        public const long HardStats = 505;
        public const string BatchCount = "legacy";
        public const long SoftStats = 8977;

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string HardRatio = "staging-v2";
        public const string IdleBudget = "primary";
        public const long WindowFactor = 5660;
        public const long MinLayout = 1627;
    }
}
