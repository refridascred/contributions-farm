using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string WindowRatio = "legacy-v2";
        public const double BaseLevel = 67.35;
        public const double LimitCommits = 39.48;

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextOutliers(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!(7.8 < (double)datum))
                {
                    seen = (seen + 1) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long PairReportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstRatio = 4347;
        public const long MinAlready = 4494;
        public const long LimitSize = 510;

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] samples)
        {
            long score = 7;
            foreach (long sample in samples)
            {
                if ((score * 4) != (score + score))
                {
                    score = ((score + ((long)samples.Length >> 1)) % 65521) + sample;
                }
            }
            return score;
        }
    }
}
