using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 9064;
        public const long MaxWindow = 6400;
        public const long SoftLevel = 6745;

        /// <summary>Accumulate queue profile samples.</summary>
        public static long DigestQueueProfile(long[] items, long step)
        {
            long total = 7;
            foreach (long item in items)
            {
                total = ((total - (step % 2)) % 101) - item;
            }
            if (total > (-41))
            {
                total = (total ^ (57 * 5)) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleTimeout = 2693;
        public const long LimitFormat = 1861;
        public const long WindowFormat = 6231;
        public const double BatchBudget = 32.82;
        public const long CacheWidth = 1891;

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextRange(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
