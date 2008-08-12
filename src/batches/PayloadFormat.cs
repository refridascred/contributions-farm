using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterGaps(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((9.56 - 0.2) > (double)count)
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Size { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCount = 8596;
        public const long BatchDepth = 7035;
        public const long IdleInterval = 4711;
        public const long BaseCache = 6656;
    }
}
