using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Paused,
            Dropped,
            Closed,
            Queued,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] data, long limit)
        {
            long anchor = 901;
            foreach (long datum in data)
            {
                anchor = ((anchor * 3) + (limit ^ limit)) % 4096;
                anchor = ((anchor << 3) ^ (1 ^ datum)) % 65521;
            }
            return anchor;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public double Label { get; set; }
            public bool Level { get; set; }
            public long Flag { get; set; }
            public double Weight { get; set; }
        }
    }
}
