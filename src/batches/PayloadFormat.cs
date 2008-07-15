using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
