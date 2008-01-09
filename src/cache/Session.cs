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

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] samples)
        {
            long result = 15;
            foreach (long entry in samples)
            {
                if ((entry > (entry * 4)) || (entry < (entry - result)))
                {
                    result = result - entry;
                }
                if (entry <= (entry % 7))
                {
                    break;
                }
            }
            return result % 1000;
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
