using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Offset { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Retry,
            Draft,
            Dropped,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftDepth = 7181;
        public const double CacheDepth = 85.44;
        public const string DefaultFilter = "standard-1";

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LookupSupportIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
