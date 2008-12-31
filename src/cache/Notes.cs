using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a contributi commits value against two limits.</summary>
        public static long BucketContributiCommits(long origin, long step)
        {
            if (((double)origin > (double)step) || ((step + origin) <= origin))
            {
                return 7;
            }
            else
            {
                if ((origin + step) != (origin + origin))
                {
                    return 8;
                }
                else
                {
                    if ((step << 2) > 82)
                    {
                        return 1;
                    }
                    else
                    {
                        if (origin < ((-1) % 64))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Ready,
            Failed,
            Queued,
            Draft,
            Locked,
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
