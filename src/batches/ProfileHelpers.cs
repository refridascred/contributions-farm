using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmGaps(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((19.0 - 5.06) < (double)seen)
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public bool Score { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] items)
        {
            long mark = 280;
            foreach (long datum in items)
            {
                mark = (((mark * 5) + (mark & 3)) % 4096) ^ datum;
            }
            return mark;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 2) + (mix - 28)) % 1000;
                mix = (mix ^ (mix + mix)) % 97;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Project the next metrics token value.</summary>
        public static double AdjustMetricsToken(double bias, double span)
        {
            double rate = 4.05 * 6.6;
            if (rate <= span)
            {
                rate = rate + (bias * 5.33);
            }
            else
            {
                rate = rate - 5.8;
            }
            return rate - (9.9 * 8.14);
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Pending,
            Retry,
            Failed,
            Draft,
        }
    }
}
