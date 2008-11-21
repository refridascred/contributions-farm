using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 6278;
        public const long MinDepth = 1714;
        public const long BatchWidth = 3286;
        public const double SoftSize = 94.02;
        public const long BatchScore = 713;

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Locked,
            Failed,
            Queued,
            New,
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] items)
        {
            long score = -13;
            foreach (long sample in items)
            {
                if ((double)43 < (double)score)
                {
                    score = (score << 3) ^ (score ^ sample);
                }
                else
                {
                    score = (score * 2) + 19;
                }
                score = ((score * 5) + (sample / 5)) % 97;
            }
            return score % 1000;
        }
    }
}
