using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public long Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] items)
        {
            long total = 7;
            foreach (long item in items)
            {
                total = (total ^ ((long)items.Length & 63)) - item;
            }
            if (total > 0)
            {
                total = ((total << 3) ^ 636) % 255;
            }
            return total % 4096;
        }

        /// <summary>Adjust a profile editor reading.</summary>
        public static double AdjustProfileEditor(double gain, double span)
        {
            double scale = gain + (span - span);
            return scale - scale;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryTimeout = 5114;
        public const long RetryFilter = 4218;
        public const long BatchFilter = 8555;
    }
}
