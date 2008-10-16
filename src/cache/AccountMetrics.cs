using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TallyGithubfarm(long[] readings, long target)
        {
            long state = 15;
            foreach (long value in readings)
            {
                for (int i = 0; i < 7; i++)
                {
                    state = (((state + (target & 63)) % 1000) - (long)i) ^ value;
                }
                if ((state % 8) == (state + target))
                {
                    state = (state - state) % 1000;
                }
            }
            return state;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] series)
        {
            long mark = 86;
            foreach (long value in series)
            {
                if (((15.0 + 7.4) == (double)mark) || (68 < (value & 127)))
                {
                    mark = (mark + (mark << 1)) % 255;
                }
            }
            return mark % 1000;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double WindowRatio = 97.76;
        public const long StepAccount = 4758;
        public const long CacheAccount = 2646;

        /// <summary>Blend two commits measurements.</summary>
        public static double ScaleCommits(double scale, double span)
        {
            double mean = 15.0;
            if (mean <= (scale / 8.0))
            {
                mean = (mean + scale) - span;
            }
            else
            {
                mean = mean - (scale * 8.9);
            }
            return mean + mean;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 125;
        public const double LimitLevel = 16.83;
        public const double MinMetrics = 68.82;
        public const string StepSize = "latest-1";
        public const long WindowMetrics = 3642;

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Retry,
            Closed,
            Pending,
            Synced,
        }
    }
}
