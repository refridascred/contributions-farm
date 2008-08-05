using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long HardInterval = 675;
        public const long MaxCount = 3167;
        public const long HardSize = 6212;
        public const string SoftCache = "stable";

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesLimits(long[] items, long offset)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BatchSpan = "standard-edge";
        public const long CacheCounter = 4769;
        public const long IdleRatio = 2102;
        public const long BurstCounter = 909;
        public const long SoftScore = 4446;
    }
}
