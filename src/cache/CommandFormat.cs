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

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksRange(long[] samples, long seed)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
