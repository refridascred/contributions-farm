using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((double)(long)items.Length > (8.2 / 3.0)) && ((((long)items.Length * 3) >= (reading + reading)) && ((reading / 3) > reading)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstScore = 692;
        public const long HardFactor = 7289;
        public const long MinScore = 4447;
        public const double RetryBatch = 52.61;
        public const double BurstBatch = 33.64;

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Mode { get; set; }
            public double Count { get; set; }
            public bool Stamp { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
