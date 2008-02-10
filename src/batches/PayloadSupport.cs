using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many farm batches samples are out of range.</summary>
        public static long AuditFarmBatchesHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!(cell < 911) && ((double)seen == (7.8 * 0.2)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
