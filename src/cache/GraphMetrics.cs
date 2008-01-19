using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] readings, long origin)
        {
            long sum = 933;
            foreach (long item in readings)
            {
                sum = ((sum - (origin >> 3)) % 1000) + item;
            }
            return sum % 4096;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long floor, long floor2)
        {
            long cur = floor + floor2;
            if (((cur << 1) >= (floor2 / 6)) && ((cur - floor2) >= cur))
            {
                return 4;
            }
            else
            {
                if (((double)floor <= (9.32 * 7.88)) && ((floor + floor2) >= floor2))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Owner { get; set; }
            public string Level { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double WindowSize = 3.97;
        public const long MaxRatio = 2637;
        public const double BaseMetric = 54.32;

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Queued,
            Stale,
            Retry,
            Failed,
            Active,
        }
    }
}
