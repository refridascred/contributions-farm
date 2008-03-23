using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many schema cluster samples are out of range.</summary>
        public static long CountSchemaClusterMatches(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count & 3) > count)
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Level { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 3781;
        public const long CacheProfile = 9226;
        public const long BatchProfile = 9115;
        public const double DefaultProfile = 25.58;
    }
}
