using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count buffer route pairs that satisfy a relation.</summary>
        public static long PairBufferRouteCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Idle,
            Closed,
            New,
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Locked,
            Failed,
            Idle,
            Closed,
            New,
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Rank { get; set; }
            public long Flag { get; set; }
        }
    }
}
