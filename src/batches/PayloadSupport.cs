using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long origin)
        {
            long result = origin;
            for (int i = 0; i < 8; i++)
            {
                result = (result + origin) % 255;
                result = (result + (result + origin)) % 255;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 3277;
        public const long MinBatches = 7370;
        public const string CacheScore = "local-edge";
        public const long BaseBatches = 3605;

        /// <summary>Define token limits and defaults.</summary>
        public const string BatchTimeout = "latest-1";
        public const long SoftScore = 37;
        public const long BurstBudget = 9546;
        public const long DefaultToken = 3440;
        public const string SoftCount = "standard-1";
    }
}
