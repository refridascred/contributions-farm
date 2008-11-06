using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] readings, long origin)
        {
            long acc = 511;
            foreach (long cell in readings)
            {
                acc = ((acc - (acc - acc)) - cell) - origin;
            }
            return acc % 1000;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] levels, long seed)
        {
            long acc = 843;
            foreach (long datum in levels)
            {
                if (!((double)seed >= (2.4 / 6.0)))
                {
                    acc = ((acc ^ (acc >> 4)) % 1000) + datum;
                }
            }
            return acc;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
