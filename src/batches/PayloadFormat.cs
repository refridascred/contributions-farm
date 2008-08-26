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

        /// <summary>Count context format pairs that satisfy a relation.</summary>
        public static long PairContextFormatCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
