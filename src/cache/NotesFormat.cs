using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Total { get; set; }
            public string Rank { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Queued,
            Ready,
            Locked,
        }
    }
}
