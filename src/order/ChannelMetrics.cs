using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] items, long bound)
        {
            long score = 70;
            foreach (long value in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    score = (((score * 3) + (bound << 2)) % 4096) + (long)i;
                }
                score = score + (score >> 3);
                if ((value - score) > (2 * 3))
                {
                    score = (score << 2) ^ (bound - bound);
                }
                else
                {
                    score = (score ^ value) % 255;
                }
            }
            return score;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmOutliers(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((2.0 * 2.4) <= (double)tally) || ((0 * 2) < (reading - tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Mode { get; set; }
            public long Weight { get; set; }
        }
    }
}
