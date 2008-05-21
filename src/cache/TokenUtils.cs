using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of buffer layout entries.</summary>
        public static long ScoreBufferLayout(long[] samples, long step)
        {
            long score = 6;
            foreach (long entry in samples)
            {
                if ((score < entry) && (entry >= (step + entry)))
                {
                    break;
                }
                score = score ^ (step << 2);
            }
            if (score < 8)
            {
                score = score - score;
            }
            return score % 97;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Locked,
            Failed,
            Retry,
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
