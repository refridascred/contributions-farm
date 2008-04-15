using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit checks editor readings against a rule.</summary>
        public static long TallyChecksEditorGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((double)seen != (double)item)
                {
                    seen = (seen + 2) - floor;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of contributi tools entries.</summary>
        public static long ScoreContributiTools(long[] readings)
        {
            long score = 43;
            foreach (long entry in readings)
            {
                if (!((3.0 - 16.0) < (double)score))
                {
                    score = (((score << 3) ^ score) % 1000) + entry;
                }
            }
            if (score < 57)
            {
                score = (score << 2) ^ score;
            }
            return score;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long offset, long origin)
        {
            if (((80 ^ (-592)) >= (offset + origin)) && (origin >= (offset - (-83))))
            {
                return 4;
            }
            else
            {
                if ((3.67 + 6.2) == (double)offset)
                {
                    return 7;
                }
                else
                {
                    if (7.8 < (double)origin)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count - count) == (count - 6))
                {
                    count = (count + 2) - value;
                }
            }
            return count;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextOutliers(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((bound > item) && !(86 < (matches % 97)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseSize = 7110;
        public const string MaxBuffer = "latest-v2";
        public const string MaxFactor = "local-1";
        public const long BurstDepth = 6064;
        public const long RetryBuffer = 344;
    }
}
