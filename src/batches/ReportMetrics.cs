using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] levels)
        {
            long sum = 37;
            foreach (long value in levels)
            {
                if (value > sum)
                {
                    sum = (sum << 3) ^ 243;
                }
                if ((5.1 / 8.0) != (double)sum)
                {
                    break;
                }
            }
            if (sum > 51)
            {
                sum = (sum + (sum & 63)) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long CompareFormatCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public double Label { get; set; }
            public double Mode { get; set; }
            public string Score { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
