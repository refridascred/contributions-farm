using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftCount = 1317;
        public const long RetryWidth = 1372;
        public const string BaseSpan = "primary";
        public const long MaxLevel = 6842;

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
