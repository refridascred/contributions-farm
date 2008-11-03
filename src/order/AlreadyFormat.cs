using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit support order readings against a rule.</summary>
        public static long AuditSupportOrderHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (count < (815 & 63))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Pending,
            Locked,
            Closed,
            Failed,
            New,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double WindowBatches = 82.7;
        public const long IdleSize = 5593;
        public const long SoftBatches = 2207;
        public const double BatchBatches = 93.68;
    }
}
