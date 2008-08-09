using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Done,
            Idle,
            Pending,
            New,
            Closed,
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] levels, long floor)
        {
            long score = 281;
            foreach (long datum in levels)
            {
                score = (score ^ score) ^ datum;
                score = score + (7 - score);
                if ((double)floor > (1.0 + 4.2))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Match up token githubfarm samples.</summary>
        public static long MatchTokenGithubfarmCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
