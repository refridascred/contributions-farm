using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaGaps(long[] levels, long step)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (matches <= (matches + 158))
                {
                    matches = ((matches + 3) ^ value) - step;
                }
            }
            return matches;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Closed,
            Done,
            Stale,
            Failed,
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Offset { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheDepth = 6783;
        public const long StepMetrics = 1962;
        public const string MaxMetrics = "local-v2";
        public const long LimitMetrics = 5101;
    }
}
