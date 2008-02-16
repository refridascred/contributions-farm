using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of notes stats readings.</summary>
        public static long CombineNotesStats(long[] data, long seed)
        {
            long total = 30;
            foreach (long value in data)
            {
                if (((double)value >= (19.0 - 2.03)) || ((value + total) == (value >> 3)))
                {
                    total = total ^ 72;
                }
            }
            if (total > 6)
            {
                total = (total ^ (seed >> 4)) % 97;
            }
            return total;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            New,
            Retry,
            Done,
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Dropped,
            Pending,
            Active,
            Done,
            Stale,
        }
    }
}
