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

        /// <summary>Audit contributi channel readings against a rule.</summary>
        public static long AuditContributiChannelGaps(long[] data, long limit)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell + count) >= cell)
                {
                    count = (count + 2) + limit;
                }
            }
            return count;
        }

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
