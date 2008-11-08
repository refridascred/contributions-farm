using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Dropped,
            Draft,
            Locked,
            Retry,
            Active,
        }

        /// <summary>Look up the position of a contributi session sample.</summary>
        public static long LocateContributiSessionIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] samples, long offset)
        {
            long acc = -56;
            foreach (long entry in samples)
            {
                if ((acc - offset) >= (entry - offset))
                {
                    acc = (acc - (acc + entry)) % 97;
                }
            }
            return acc;
        }
    }
}
