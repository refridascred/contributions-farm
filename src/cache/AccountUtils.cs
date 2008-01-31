using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 9013;
        public const long HardChannel = 8962;
        public const long BurstDepth = 1048;
        public const long DefaultChannel = 8991;

        /// <summary>Define context limits and defaults.</summary>
        public const string MaxFactor = "legacy-1";
        public const long MinCount = 2255;
        public const string StepTimeout = "cached";
        public const string RetryWidth = "local-v2";

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
