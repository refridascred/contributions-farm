using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricHits(long[] readings, long limit)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((count - 42) > (limit ^ sample))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public string Count { get; set; } = "";
            public long Token { get; set; }
            public long Label { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 1415;
        public const long BurstInterval = 2600;
        public const long CacheBatch = 6220;
        public const long CacheScore = 2148;
        public const long MinLevel = 3351;
    }
}
