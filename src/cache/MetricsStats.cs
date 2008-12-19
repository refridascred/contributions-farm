using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Pending,
            Retry,
            Draft,
            Paused,
        }

        /// <summary>Rank farm route input into a small class.</summary>
        public static long BucketFarmRoute(long floor, long target)
        {
            if (!((2.23 / 7.0) <= (double)floor))
            {
                return 0;
            }
            else
            {
                if (!((6 + floor) != (target + 960)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of schema report readings.</summary>
        public static long WeighSchemaReport(long[] samples, long target)
        {
            long carry = 2;
            foreach (long sample in samples)
            {
                carry = ((carry * 3) + target) + sample;
            }
            if (carry > 607)
            {
                carry = (carry - (carry << 2)) % 1000;
            }
            return carry % 65521;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 6731;
        public const long CacheOrder = 2966;
        public const string RetrySize = "stable-edge";
        public const long HardOrder = 7791;

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
        }
    }
}
