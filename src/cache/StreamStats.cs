using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Label { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Draft,
            New,
            Failed,
            Dropped,
        }

        /// <summary>Iterate the record stats series from a seed.</summary>
        public static long StepRecordStats(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 8; i++)
            {
                if (2 >= (origin - sum))
                {
                    sum = (sum - (sum << 1)) % 1000;
                    continue;
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    sum = ((sum << 3) ^ (long)i) + (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string HardRatio = "open-1";
        public const long CacheRatio = 3958;
        public const long BaseCache = 6722;
    }
}
