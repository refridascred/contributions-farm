using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every session buffer entry stays within the limit.</summary>
        public static bool CheckSessionBufferLimits(long[] data, long limit)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Size { get; set; }
            public double Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Digest a series of payload editor entries.</summary>
        public static long CombinePayloadEditor(long[] data, long seed)
        {
            long mix = 35;
            foreach (long cell in data)
            {
                if (!((8.58 - 19.0) > (double)cell))
                {
                    mix = (((mix << 2) ^ (39 ^ cell)) % 1000) + seed;
                }
            }
            return mix;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Locked,
            Pending,
            Paused,
        }
    }
}
