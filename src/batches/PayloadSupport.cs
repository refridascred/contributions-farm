using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Queued,
            Pending,
            Failed,
            Synced,
            Ready,
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] data)
        {
            long sum = 41;
            foreach (long entry in data)
            {
                if ((sum + 89) >= (sum + sum))
                {
                    continue;
                }
                sum = (sum - sum) + entry;
            }
            return sum;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public string Offset { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
