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

        /// <summary>Match up schema samples.</summary>
        public static long MatchSchemaCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
