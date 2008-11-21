using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] data)
        {
            long result = 0;
            foreach (long reading in data)
            {
                result = ((result << 2) ^ (89 >> 5)) + reading;
            }
            return result % 1000;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultFactor = 5657;
        public const string SoftWidth = "strict";
        public const long StepBatch = 435;
        public const long LimitBudget = 4260;
        public const double BaseCount = 71.25;

        /// <summary>Match up route samples.</summary>
        public static long CompareRouteCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            New,
            Done,
            Stale,
            Paused,
        }
    }
}
