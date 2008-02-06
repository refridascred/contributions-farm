using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string CacheScore = "primary-v2";
        public const string MaxReport = "fallback-edge";
        public const long BurstReport = 4412;
        public const double BatchReport = 12.32;
        public const long BaseReport = 1925;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultFactor = 8015;
        public const double HardBuffer = 56.1;
        public const long WindowBuffer = 1442;
        public const long MaxWidth = 8846;
        public const string BaseInterval = "latest-v2";

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaGaps(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count - count) >= (count & 255))
                {
                    count = (count + 2) - datum;
                }
            }
            return count;
        }
    }
}
