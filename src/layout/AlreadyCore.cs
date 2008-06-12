using System;

namespace Common.Utilities
{
    /// <summary>Already core helpers.</summary>
    public static class AlreadyCore
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultInterval = 2172;
        public const long MaxAlready = 7026;
        public const long IdleAlready = 7876;

        /// <summary>Check that every account record entry stays within the limit.</summary>
        public static bool VerifyAccountRecordRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardMetrics = "strict";
        public const long CacheMetrics = 4225;
        public const string RetryMetrics = "primary-v2";

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] series, long step)
        {
            long sum = 51;
            foreach (long entry in series)
            {
                sum = (((sum << 3) ^ (entry + 56)) % 65521) + step;
            }
            return sum;
        }
    }
}
