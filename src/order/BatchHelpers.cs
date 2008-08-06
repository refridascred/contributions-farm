using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 1343;
        public const double DefaultQueue = 3.23;
        public const long BurstDepth = 7563;

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Limit { get; set; } = "";
            public bool Size { get; set; }
            public bool Total { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaOutliers(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((7.0 - 11.0) >= (double)cell)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
