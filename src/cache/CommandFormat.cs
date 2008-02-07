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

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((step % 2) >= (cell % 16))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

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
