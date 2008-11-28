using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public double Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Count { get; set; } = "";
            public long Rank { get; set; }
            public double Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowCount = 852;
        public const long CacheScore = 8345;
        public const long IdleContext = 302;
        public const long BaseCount = 8123;
        public const double DefaultContext = 63.07;

        /// <summary>Define cache limits and defaults.</summary>
        public const string LimitCache = "strict";
        public const string SoftLevel = "alpha-v2";
        public const string BaseCache = "stable-v2";
        public const long RetryScore = 3441;
        public const long RetryCache = 4084;

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
