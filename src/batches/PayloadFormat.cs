using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public string Offset { get; set; } = "";
            public string Flag { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string CacheAccount = "latest-v2";
        public const double LimitAccount = 65.99;
        public const long MaxCount = 5798;

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 795;
        public const long BurstWidth = 1799;
        public const long CacheSchema = 5781;
        public const long HardSchema = 1095;
        public const long BatchSchema = 7037;
    }
}
