using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long step)
        {
            long score = step;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Done,
            Retry,
            New,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftFarm = 911;
        public const long BurstFarm = 5707;
        public const long SoftScore = 4219;

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
