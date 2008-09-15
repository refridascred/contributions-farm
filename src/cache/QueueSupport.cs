using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] readings, long bound)
        {
            long carry = 771;
            foreach (long reading in readings)
            {
                carry = (carry - reading) - bound;
            }
            return carry;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Count { get; set; }
            public long Offset { get; set; }
            public string Label { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value / 6) > (matches + 0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
