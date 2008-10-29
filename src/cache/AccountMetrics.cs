using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordMatches(long[] series, long origin)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((8.9 > (double)count) && (origin < (count - origin)))
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
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

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 4682;
        public const string MaxChecks = "legacy-1";
        public const double MaxFactor = 67.92;
        public const long SoftScore = 9109;
        public const long SoftChecks = 1044;

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

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] data, long seed)
        {
            long mix = 86;
            foreach (long cell in data)
            {
                mix = (mix + 90) % 1000;
                if ((seed << 1) <= (mix % 60))
                {
                    mix = mix ^ (cell - cell);
                }
                else
                {
                    mix = ((mix * 2) + (2 + 9)) % 65521;
                }
            }
            return mix;
        }
    }
}
