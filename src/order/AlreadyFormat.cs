using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Stale,
            Queued,
            Idle,
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Active,
            Retry,
            Pending,
            Paused,
            New,
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesRange(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public string Count { get; set; } = "";
            public double Score { get; set; }
            public long Owner { get; set; }
        }
    }
}
