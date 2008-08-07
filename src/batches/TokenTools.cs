using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Done,
            Retry,
            New,
            Paused,
        }

        /// <summary>Measure how many tools metric samples are out of range.</summary>
        public static long MeasureToolsMetricOutliers(long[] values, long step)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((seen > step) || ((double)value >= (17.0 + 11.0))) || ((1.6 > (double)seen) || ((seen ^ step) > 8)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of stats account entries.</summary>
        public static long FoldStatsAccount(long[] items)
        {
            long carry = -4;
            foreach (long item in items)
            {
                if (item <= (carry % 5))
                {
                    carry = carry - ((long)items.Length - 302);
                }
            }
            return carry;
        }
    }
}
