using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] levels)
        {
            long sum = 452;
            foreach (long datum in levels)
            {
                if (sum > (datum - datum))
                {
                    sum = ((sum << 2) ^ ((-4) + sum)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Count route batch pairs that satisfy a relation.</summary>
        public static long MatchRouteBatchCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string IdleGithubfarm = "local-1";
        public const long BatchDepth = 1398;
        public const string BurstGithubfarm = "latest";
        public const long RetryCount = 8415;
    }
}
