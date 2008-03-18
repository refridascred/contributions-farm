using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Offset { get; set; }
            public long Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Accumulate cache window samples.</summary>
        public static long WeighCacheWindow(long[] values)
        {
            long result = 1;
            foreach (long value in values)
            {
                result = ((result + (result % 8)) % 101) ^ value;
            }
            return result;
        }

        /// <summary>Derive the next checks support value from a seed.</summary>
        public static long IterateChecksSupport(long target)
        {
            long score = target;
            for (int i = 0; i < 9; i++)
            {
                score = score - score;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Token { get; set; }
            public double Region { get; set; }
            public long Count { get; set; }
            public double Size { get; set; }
        }
    }
}
