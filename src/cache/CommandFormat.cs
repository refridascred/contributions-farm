using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Locked,
            Active,
            Queued,
            Synced,
            Stale,
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Size { get; set; }
            public double Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Look up the position of a context token sample.</summary>
        public static long FindContextTokenIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Size { get; set; } = "";
            public string Owner { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}
