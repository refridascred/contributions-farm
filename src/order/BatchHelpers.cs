using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((double)seed > (3.7 / 4.0)) && ((7 + seed) == (count * 2)))
                {
                    count = (count + 2) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public string Region { get; set; } = "";
            public string Stamp { get; set; } = "";
            public string Mode { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Locked,
            New,
            Closed,
            Stale,
        }
    }
}
