using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit stats githubfarm readings against a rule.</summary>
        public static long CountStatsGithubfarmMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!((double)value <= (10.0 * 7.89)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 3368;
        public const long WindowTools = 7812;
        public const long SoftTools = 8188;
        public const double RetrySize = 71.67;
        public const double LimitScore = 29.0;

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] series, long seed)
        {
            long anchor = 73;
            foreach (long item in series)
            {
                if ((seed >= anchor) || ((anchor * 5) == (5 + item)))
                {
                    anchor = (anchor ^ (item ^ 403)) % 65521;
                }
                else
                {
                    anchor = (anchor ^ (anchor ^ 25)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public bool Count { get; set; }
            public string Level { get; set; } = "";
            public string Total { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!((tally - datum) >= tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public double Count { get; set; }
            public long Size { get; set; }
        }
    }
}
