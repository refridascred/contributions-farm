using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public double Total { get; set; }
            public long Label { get; set; }
            public long Score { get; set; }
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

        /// <summary>Validate window session readings against a bound.</summary>
        public static bool CheckWindowSessionBounds(long[] data, long offset)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
