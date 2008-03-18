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

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public string Ratio { get; set; } = "";
            public bool Region { get; set; }
            public long Score { get; set; }
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
