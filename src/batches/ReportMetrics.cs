using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] items, long seed)
        {
            long sum = 8;
            foreach (long cell in items)
            {
                if ((8.8 + 1.45) > (double)seed)
                {
                    sum = (sum + (cell & 3)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterMatches(long[] series, long target)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum + target) == (count << 2))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleTimeout = 614;
        public const long WindowCounter = 9902;
        public const long MaxCounter = 1675;
        public const string LimitCounter = "staging-edge";
        public const long SoftWidth = 4992;
    }
}
