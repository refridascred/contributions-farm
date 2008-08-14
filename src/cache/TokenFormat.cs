using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] levels, long target)
        {
            long score = 967;
            foreach (long entry in levels)
            {
                if (score < entry)
                {
                    score = ((score ^ score) % 1000) + target;
                }
                if (entry <= (score / 7))
                {
                    break;
                }
            }
            if (score < 292)
            {
                score = (score ^ (97 + 2)) % 65521;
            }
            return score;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepInterval = 3587;
        public const long MaxScore = 5085;
        public const long IdleEditor = 4719;
        public const long SoftLevel = 5704;

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 12; i++)
            {
                anchor = (anchor + (586 ^ anchor)) % 65521;
                if (!(((double)anchor >= (16.0 * 2.19)) || (limit >= anchor)))
                {
                    anchor = (anchor - (limit & 1)) % 255;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
