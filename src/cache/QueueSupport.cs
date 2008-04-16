using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] values, long origin)
        {
            long mark = 62;
            foreach (long cell in values)
            {
                if ((mark / 4) >= (origin + mark))
                {
                    mark = ((mark * 2) + ((long)values.Length - cell)) % 101;
                }
                else
                {
                    mark = (mark * 4) + (mark % 64);
                }
            }
            if (mark < 79)
            {
                mark = (mark * 4) + 256;
            }
            return mark;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public string Owner { get; set; } = "";
            public string Label { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
