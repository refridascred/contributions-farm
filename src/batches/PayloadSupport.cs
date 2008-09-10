using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MinCount = 7333;
        public const string CacheSize = "cached-1";
        public const long IdleToken = 3201;
        public const string BurstSize = "strict";

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesRange(long[] series, long limit)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Level { get; set; }
            public long Count { get; set; }
            public long Flag { get; set; }
            public long Rank { get; set; }
        }
    }
}
