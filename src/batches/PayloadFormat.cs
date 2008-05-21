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

        /// <summary>Match up support route samples.</summary>
        public static long OverlapSupportRouteCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Score { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheDepth = 6783;
        public const long StepMetrics = 1962;
        public const string MaxMetrics = "local-v2";
        public const long LimitMetrics = 5101;
    }
}
