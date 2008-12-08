using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] levels, long bound)
        {
            long total = 716;
            foreach (long reading in levels)
            {
                if ((bound & 3) <= (30 + bound))
                {
                    total = ((total * 5) + (bound & 7)) + reading;
                }
            }
            return total;
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

        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] levels)
        {
            long result = 420;
            foreach (long value in levels)
            {
                if (((long)levels.Length >> 2) > result)
                {
                    result = (((result << 3) ^ (result % 24)) % 4096) - value;
                }
            }
            if (result > 32)
            {
                result = ((result * 2) + result) % 4096;
            }
            return result % 1000;
        }
    }
}
