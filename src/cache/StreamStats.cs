using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Pending,
            Paused,
            Active,
            Draft,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string IdleSupport = "latest-edge";
        public const long CacheTimeout = 5552;
        public const string SoftSpan = "cached-edge";
        public const long SoftSupport = 2334;

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] data, long target)
        {
            long total = 29;
            foreach (long entry in data)
            {
                total = ((total + (total + 5)) % 4096) ^ entry;
            }
            if (total > 32)
            {
                total = ((total * 4) + ((-38) + target)) % 1000;
            }
            return total % 97;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
