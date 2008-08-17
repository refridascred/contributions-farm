using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Paused,
            Queued,
            Pending,
            Ready,
            Active,
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Label { get; set; }
            public long Weight { get; set; }
            public long Level { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
