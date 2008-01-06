using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a layout githubfarm reading by value.</summary>
        public static long LookupLayoutGithubfarmIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Synced,
            Pending,
            New,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string BatchSpan = "standard-v2";
        public const long DefaultLayout = 5232;
        public const double SoftLayout = 92.35;
        public const long MaxLayout = 6190;
    }
}
