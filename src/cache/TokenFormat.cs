using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Size { get; set; } = "";
            public long Count { get; set; }
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Active,
            Queued,
            Dropped,
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((count + reading) >= (count * 4))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
