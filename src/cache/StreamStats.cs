using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string MinSchema = "primary-v2";
        public const long BurstDepth = 6225;
        public const long MaxSchema = 4464;
        public const long LimitSchema = 7;

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long floor, long seed)
        {
            long next = floor - seed;
            if ((floor + seed) != (next + floor))
            {
                return 4;
            }
            else
            {
                if (seed >= (floor ^ seed))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Flag { get; set; }
            public long Total { get; set; }
        }
    }
}
