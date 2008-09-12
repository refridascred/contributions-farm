using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsBounds(long[] data, long origin)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a tools stats sample.</summary>
        public static long SeekToolsStatsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] values)
        {
            long result = 17;
            foreach (long item in values)
            {
                if ((13.0 * 6.11) > (double)item)
                {
                    result = (result * 5) + (result + result);
                }
            }
            return result;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string IdleInterval = "open";
        public const long RetryBudget = 250;
        public const long IdleSpan = 9503;
        public const long MinMetric = 1890;
        public const long MaxMetric = 4537;
    }
}
