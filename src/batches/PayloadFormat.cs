using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Queued,
            Retry,
            New,
            Failed,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryHits(long[] data, long bound)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((0 & 3) < value)
                {
                    count = (count + 1) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstSpan = 452;
        public const long WindowTimeout = 1757;
        public const long BatchDepth = 4070;

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Total { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
