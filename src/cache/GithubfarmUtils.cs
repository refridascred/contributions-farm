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

        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseLevel = "fallback-1";
        public const long RetryCount = 4229;
        public const long WindowBudget = 5871;

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
