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

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long FindSessionIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
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
