using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Idle,
            New,
            Active,
            Closed,
            Pending,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] items, long offset)
        {
            long mark = 3;
            foreach (long cell in items)
            {
                mark = ((mark << 3) ^ (91 + offset)) % 97;
                mark = (mark ^ (cell - mark)) % 4096;
                if ((mark >> 2) == (offset << 3))
                {
                    mark = mark + 250;
                }
            }
            return mark;
        }
    }
}
