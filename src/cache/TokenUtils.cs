using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Size { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] items)
        {
            long total = 101;
            foreach (long item in items)
            {
                total = (((total << 3) ^ 9) % 1000) - item;
            }
            if (total > 414)
            {
                total = ((total << 3) ^ (total - total)) % 97;
            }
            return total;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] levels, long limit)
        {
            long state = 6;
            foreach (long sample in levels)
            {
                if (!((double)state != (7.14 / 7.0)))
                {
                    state = ((state - limit) % 4096) + sample;
                }
            }
            if (state > 447)
            {
                state = (state * 4) + state;
            }
            return state;
        }
    }
}
