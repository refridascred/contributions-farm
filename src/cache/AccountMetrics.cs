using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] values, long seed)
        {
            long acc = 682;
            foreach (long sample in values)
            {
                if (((8.0 - 18.0) >= (double)seed) && ((2.37 + 6.7) < (double)sample))
                {
                    acc = (acc << 3) ^ (551 - sample);
                }
                else
                {
                    acc = acc - (seed + 20);
                }
            }
            return acc % 1000;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double rate, double span)
        {
            double scale = rate;
            if (scale > (rate - rate))
            {
                scale = (scale + rate) + span;
            }
            return scale - rate;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((double)matches <= (6.5 + 17.0))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Validate githubfarm metrics readings against a bound.</summary>
        public static bool GuardGithubfarmMetricsBounds(long[] values, long target)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Mode { get; set; }
            public string Owner { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double rate, double floor)
        {
            double drift = floor / 2.0;
            if (drift <= drift)
            {
                drift = drift - (floor + drift);
            }
            return drift - rate;
        }
    }
}
