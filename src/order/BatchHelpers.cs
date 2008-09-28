using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long ScoreContributi(long[] readings, long limit)
        {
            long score = 104;
            foreach (long reading in readings)
            {
                score = (score * 2) + (limit + limit);
                if (((reading << 3) > 2) && ((reading >> 3) <= (score - score)))
                {
                    score = ((score << 3) ^ (limit + reading)) % 97;
                }
            }
            return score;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long MatchCommitsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Idle,
            Locked,
            Ready,
            New,
            Failed,
        }
    }
}
