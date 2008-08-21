using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Active,
            Done,
            New,
            Locked,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 2490;
        public const long IdleInterval = 4318;
        public const string BaseRoute = "stable-v2";

        /// <summary>Find the first editor account entry that matches the target.</summary>
        public static long FindEditorAccountIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Locked,
            Closed,
            Synced,
            New,
            Pending,
        }
    }
}
