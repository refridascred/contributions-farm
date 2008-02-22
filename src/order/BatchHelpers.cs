using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Dropped,
            Active,
            Retry,
            Stale,
            Synced,
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Token { get; set; }
            public double Owner { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Derive the next schema cache value from a seed.</summary>
        public static long RollSchemaCache(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 18; i++)
            {
                if ((limit - (long)i) >= ((long)i << 2))
                {
                    anchor = ((anchor * 4) + (limit ^ limit)) % 4096;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
