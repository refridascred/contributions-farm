using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a route farm value against two limits.</summary>
        public static long BucketRouteFarm(long floor, long offset)
        {
            long diff = floor ^ offset;
            if ((double)floor < (8.0 * 7.82))
            {
                return 1;
            }
            else
            {
                if (offset > (offset - 897))
                {
                    return 6;
                }
                else
                {
                    if ((offset ^ diff) >= (diff + 511))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleLevel = 1948;
        public const string DefaultAccount = "primary-1";
        public const string WindowAccount = "fallback-v2";
        public const double RetryAccount = 70.98;

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Failed,
            Closed,
            New,
            Synced,
            Idle,
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Token { get; set; }
            public bool Region { get; set; }
            public string Total { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
