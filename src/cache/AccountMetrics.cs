using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 8023;
        public const long RetryLevel = 2047;
        public const long HardFarm = 9379;
        public const long LimitFarm = 8398;
        public const long BaseFarm = 667;

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

        /// <summary>Locate a buffer metric reading by value.</summary>
        public static long LookupBufferMetricIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
