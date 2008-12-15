using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Locked,
            Stale,
            Synced,
        }

        /// <summary>Measure how many tools command samples are out of range.</summary>
        public static long AuditToolsCommandGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((tally - cell) == (origin - tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] readings)
        {
            long acc = 93;
            foreach (long cell in readings)
            {
                if ((acc ^ (long)readings.Length) < 30)
                {
                    acc = (acc + cell) % 1000;
                }
            }
            return acc % 1000;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MaxGithubfarm = "latest-edge";
        public const long BurstRatio = 1818;
        public const long DefaultWidth = 8394;
        public const long MinGithubfarm = 8848;
    }
}
