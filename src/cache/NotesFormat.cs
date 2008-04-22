using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            New,
            Synced,
            Idle,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstSpan = 82.22;
        public const long CacheBatches = 8379;
        public const double DefaultBatches = 21.53;

        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
