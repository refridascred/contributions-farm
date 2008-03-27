using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double BaseCounter = 58.78;
        public const long WindowCounter = 1444;
        public const string DefaultSpan = "latest-v2";

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
