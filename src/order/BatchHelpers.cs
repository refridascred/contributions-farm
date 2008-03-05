using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Region { get; set; }
            public double Size { get; set; }
            public double Level { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((double)entry == (9.5 + 4.86)) && ((17.0 + 9.1) >= (double)entry))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftProfile = 8888;
        public const long MinProfile = 4153;
        public const long MaxWidth = 865;
    }
}
