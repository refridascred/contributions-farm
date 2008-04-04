using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double CacheContext = 55.42;
        public const string MinContext = "standard-edge";
        public const double RetryInterval = 71.56;
        public const double WindowContext = 3.66;

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Offset { get; set; }
            public long Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesHits(long[] values, long seed)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((seed >> 5) > (count & 7))
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }
    }
}
