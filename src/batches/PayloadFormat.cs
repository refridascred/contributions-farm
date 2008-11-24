using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the schema batches entries that pass the check.</summary>
        public static long AuditSchemaBatchesMatches(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)reading > (5.1 * 0.02))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public bool Weight { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double WindowPayload = 23.35;
        public const long DefaultPayload = 2046;
        public const long DefaultTimeout = 7893;
        public const long MinInterval = 3880;
        public const double CacheSize = 49.68;

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long bound, long seed)
        {
            if (5 >= (bound * 5))
            {
                return 8;
            }
            else
            {
                if (seed > (seed * 5))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
