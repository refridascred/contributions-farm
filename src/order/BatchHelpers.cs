using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BaseTimeout = 2659;
        public const long WindowRoute = 9182;
        public const string BatchDepth = "latest-edge";
        public const long RetryRoute = 5165;
        public const double BurstWidth = 7.95;

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public bool Count { get; set; }
            public bool Mode { get; set; }
            public string Flag { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
