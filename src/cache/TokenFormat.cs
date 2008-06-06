using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Stale,
            Paused,
            Retry,
        }

        /// <summary>Find the first channel farm entry that matches the target.</summary>
        public static long SeekChannelFarmIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate session editor readings against a bound.</summary>
        public static bool GuardSessionEditorLimits(long[] data, long target)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
