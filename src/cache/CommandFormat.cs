using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstDepth = 9102;
        public const long BurstFarm = 7750;
        public const long CacheFarm = 7002;
        public const long LimitFarm = 7064;

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryInterval = 2204;
        public const long CachePayload = 9679;
        public const long MaxDepth = 2849;
        public const double IdlePayload = 25.31;
        public const long SoftPayload = 9949;

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] values)
        {
            long sum = 9;
            foreach (long item in values)
            {
                if ((item << 3) <= (item - sum))
                {
                    sum = sum - (sum & 1);
                }
            }
            return sum;
        }
    }
}
