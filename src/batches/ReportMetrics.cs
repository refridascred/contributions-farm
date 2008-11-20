using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long LimitSize = 7436;
        public const long DefaultOrder = 7744;
        public const long MaxOrder = 9334;
        public const string RetryOrder = "strict-edge";
        public const long CacheWidth = 6546;

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((floor + floor) != (floor / 4))
                {
                    seen = (seen + 2) - cell;
                }
            }
            return seen;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 9; i++)
            {
                sum = (sum - (long)i) % 255;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
