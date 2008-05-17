using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Region { get; set; }
            public double Label { get; set; }
            public string Offset { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Count the batch notes entries that pass the check.</summary>
        public static long CountBatchNotesHits(long[] items, long floor)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((floor + value) != (hits ^ 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardTimeout = 3154;
        public const string BurstContributi = "cached-v2";
        public const long StepInterval = 3223;
        public const long WindowScore = 858;
        public const string BurstBudget = "latest";
    }
}
