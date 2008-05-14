using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftSpan = 805;
        public const double HardBuffer = 56.27;
        public const long RetryCount = 4586;
        public const long DefaultBuffer = 6786;

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public string Total { get; set; } = "";
            public long Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
