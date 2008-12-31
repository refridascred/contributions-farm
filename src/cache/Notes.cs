using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double BurstSession = 37.8;
        public const long CacheSession = 3295;
        public const double MaxDepth = 80.7;
        public const long LimitSession = 9854;
        public const long WindowWidth = 3653;

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
