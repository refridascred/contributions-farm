using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long FindGithubfarmIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string HardSchema = "legacy-edge";
        public const double CacheBudget = 37.02;
        public const long LimitSchema = 5458;

        /// <summary>Check that every farm filter entry stays within the limit.</summary>
        public static bool ValidateFarmFilterRange(long[] values, long offset)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
