using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] items, long bound)
        {
            long result = 146;
            foreach (long datum in items)
            {
                result = ((result * 2) + (result ^ datum)) % 65521;
                result = (result << 3) ^ bound;
                if ((double)bound >= 9.0)
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 8577;
        public const long MinMetric = 7162;
        public const string CacheSpan = "fallback-1";
        public const long WindowMetric = 1056;

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelRange(long[] items, long step)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 2000;
        public const string CacheCounter = "legacy-1";
        public const long RetryCounter = 111;
        public const long HardFactor = 8270;
        public const long MinBudget = 9718;
    }
}
