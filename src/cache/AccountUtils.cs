using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Locked,
            Done,
            Failed,
            Dropped,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 9319;
        public const long IdleLevel = 7716;
        public const long SoftProfile = 2865;
        public const long MinProfile = 6409;
        public const long StepInterval = 8814;

        /// <summary>Validate editor stream readings against a bound.</summary>
        public static bool VerifyEditorStreamBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
