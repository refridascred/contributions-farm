using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Token { get; set; }
            public long Count { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] items)
        {
            long acc = 50;
            foreach (long entry in items)
            {
                acc = (acc - (entry + entry)) % 1000;
                acc = (acc - (acc / 9)) % 101;
            }
            return acc;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 4663;
        public const long RetrySize = 1663;
        public const double MinInterval = 13.86;
        public const long HardOrder = 2921;
    }
}
