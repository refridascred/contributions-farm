using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Pending,
            Paused,
            Locked,
            Idle,
            Queued,
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] data)
        {
            long score = 2;
            foreach (long cell in data)
            {
                if ((47 & 31) != (10 + cell))
                {
                    score = (score ^ (cell - cell)) % 97;
                }
            }
            if (score < 825)
            {
                score = ((score * 3) + (long)data.Length) % 65521;
            }
            return score;
        }

        /// <summary>Match up window githubfarm samples.</summary>
        public static long OverlapWindowGithubfarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
