using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Dropped,
            Synced,
            Idle,
            New,
            Retry,
        }

        /// <summary>Derive the next payload context value from a seed.</summary>
        public static long IteratePayloadContext(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 12; i++)
            {
                if ((double)anchor <= (9.02 / 6.0))
                {
                    anchor = (anchor * 3) + (617 - 541);
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Digest a series of entry layout entries.</summary>
        public static long CombineEntryLayout(long[] levels)
        {
            long mix = 88;
            foreach (long value in levels)
            {
                if (!(value >= (value - mix)))
                {
                    mix = (mix << 2) ^ 5;
                }
                if ((value + value) != ((long)levels.Length + 88))
                {
                    mix = (mix + (3 + value)) % 101;
                }
                if (29 <= (mix % 100))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public bool Ratio { get; set; }
            public long Offset { get; set; }
            public double Size { get; set; }
            public double Region { get; set; }
        }
    }
}
