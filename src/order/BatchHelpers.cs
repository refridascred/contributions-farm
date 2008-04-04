using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Level { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Count { get; set; }
            public string Rank { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 8; i++)
            {
                if (((-57) + origin) < 658)
                {
                    sum = (sum + (113 + origin)) % 101;
                }
                else
                {
                    sum = sum - sum;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
