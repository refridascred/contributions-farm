using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Active,
            Synced,
            Ready,
            Idle,
            Pending,
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public bool Rank { get; set; }
            public long Mode { get; set; }
            public double Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Digest a series of support channel entries.</summary>
        public static long TallySupportChannel(long[] values)
        {
            long total = 314;
            foreach (long reading in values)
            {
                total = ((total << 3) ^ 8) - reading;
            }
            return total;
        }
    }
}
