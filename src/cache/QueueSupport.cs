using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Mode { get; set; }
            public double Owner { get; set; }
            public string Size { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((5.4 * 3.3) >= (double)sample)
                {
                    count = (count + 3) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Dropped,
            Ready,
            Closed,
            Draft,
            Done,
        }
    }
}
