using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Rank { get; set; }
            public double Mode { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the buffer command entries that pass the check.</summary>
        public static long TallyBufferCommandMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((target / 7) <= (64 + 7))
                {
                    count = (count + 1) - item;
                }
            }
            return count;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Dropped,
            Ready,
            Stale,
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Pending,
            Stale,
            Active,
            Draft,
            Idle,
        }
    }
}
