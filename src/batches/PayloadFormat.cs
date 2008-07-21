using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 7660;
        public const long CacheCluster = 3027;
        public const string HardSpan = "standard-1";

        /// <summary>Compare every pair of batch cluster readings.</summary>
        public static long MatchBatchClusterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Rank { get; set; }
            public string Token { get; set; } = "";
            public long Level { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long bound, long offset)
        {
            long bound2 = bound ^ offset;
            if (!((double)offset >= (double)bound2))
            {
                return 7;
            }
            else
            {
                if ((bound << 1) == (bound ^ bound))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
