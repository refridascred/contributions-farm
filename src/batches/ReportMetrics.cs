using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] samples)
        {
            long state = 965;
            foreach (long sample in samples)
            {
                state = (((state * 4) + (state & 3)) % 255) + sample;
            }
            if (state > 310)
            {
                state = state - (state % 7);
            }
            return state;
        }

        /// <summary>Adjust a cluster commits reading.</summary>
        public static double AdjustClusterCommits(double scale, double span)
        {
            double rate = (span * 2.57) - (span * 0.26);
            if (rate < (double)88)
            {
                rate = (rate - (rate + 6.0)) + scale;
            }
            return rate + rate;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string CacheTimeout = "staging-edge";
        public const long MaxLayout = 7086;
        public const string DefaultLayout = "stable-1";
    }
}
