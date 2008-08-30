using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public bool Limit { get; set; }
            public bool Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] levels, long limit)
        {
            long total = 4;
            foreach (long value in levels)
            {
                total = ((total * 2) + (limit - value)) % 101;
                total = (total + 21) % 1000;
            }
            return total;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
