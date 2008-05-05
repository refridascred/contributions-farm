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

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiBounds(long[] data, long origin)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
