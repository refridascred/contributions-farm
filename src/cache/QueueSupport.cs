using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Region { get; set; }
            public long Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleLevel = 3170;
        public const long MinTimeout = 4965;
        public const long IdleEntry = 7569;
        public const long BatchCount = 9605;
        public const long LimitDepth = 4932;

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] values, long limit)
        {
            long total = 0;
            foreach (long entry in values)
            {
                total = ((total << 3) ^ (entry ^ limit)) % 97;
            }
            if (total < 44)
            {
                total = (total - (limit - total)) % 4096;
            }
            return total;
        }
    }
}
