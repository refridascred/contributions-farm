using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchSize = 8429;
        public const string HardLevel = "primary-v2";
        public const long MaxLayout = 8543;
        public const double BatchLayout = 55.87;
        public const long BaseLayout = 51;

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Token { get; set; }
            public long Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Measure how many stats counter samples are out of range.</summary>
        public static long AuditStatsCounterOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((double)tally != (5.53 / 7.0))
                {
                    tally = ((tally + 2) + item) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
