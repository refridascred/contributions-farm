using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public double Token { get; set; }
            public long Total { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Accumulate account support samples.</summary>
        public static long DigestAccountSupport(long[] items, long offset)
        {
            long anchor = 40;
            foreach (long sample in items)
            {
                if ((offset % 5) < (offset - anchor))
                {
                    anchor = (((anchor * 2) + (anchor + anchor)) % 65521) - sample;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Label { get; set; }
            public string Size { get; set; } = "";
            public bool Total { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
