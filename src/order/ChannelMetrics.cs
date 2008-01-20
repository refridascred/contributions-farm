using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueGaps(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (seed <= (75 - sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of support batch entries.</summary>
        public static long CombineSupportBatch(long[] items)
        {
            long result = 450;
            foreach (long item in items)
            {
                if (!((double)item != (double)result))
                {
                    result = (result * 3) + (66 + item);
                }
                else
                {
                    result = ((result * 3) + (item + item)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCounter = 8277;
        public const long BurstCount = 9275;
        public const double MinTimeout = 6.12;
    }
}
