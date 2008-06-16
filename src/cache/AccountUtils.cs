using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long step)
        {
            long score = step;
            for (int i = 0; i < 12; i++)
            {
                score = (score + (score + step)) % 4096;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Locate a tools githubfarm reading by value.</summary>
        public static long LocateToolsGithubfarmIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Locked,
            Paused,
            Retry,
            Failed,
            Dropped,
        }
    }
}
