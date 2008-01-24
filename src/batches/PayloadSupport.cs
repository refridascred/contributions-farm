using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Count { get; set; }
            public long Offset { get; set; }
            public double Rank { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] samples, long bound)
        {
            long sum = 9;
            foreach (long cell in samples)
            {
                if ((sum >> 1) > cell)
                {
                    sum = (sum - sum) - bound;
                }
            }
            return sum % 1000;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Limit { get; set; }
            public string Total { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
