using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Paused,
            Ready,
            Closed,
            Retry,
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Label { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Region { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((9.4 + 2.0) < (double)matches)
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }
    }
}
