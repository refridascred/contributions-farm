using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Queued,
            Synced,
            Done,
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a context account counter forward.</summary>
        public static long RollContextAccount(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 8; i++)
            {
                anchor = (anchor + (origin + (-84))) % 65521;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Level { get; set; }
            public bool Rank { get; set; }
            public double Mode { get; set; }
            public long Ratio { get; set; }
        }
    }
}
