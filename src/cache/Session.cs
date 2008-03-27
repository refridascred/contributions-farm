using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double DefaultRecord = 78.82;
        public const string BurstRecord = "primary-edge";
        public const double CacheSpan = 86.34;
        public const double WindowRecord = 7.13;

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public bool Offset { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
