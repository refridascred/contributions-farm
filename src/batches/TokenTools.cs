using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a counter profile pair into a bucket.</summary>
        public static long SortCounterProfile(long limit, long floor)
        {
            long slot = limit + floor;
            if (!(slot < limit))
            {
                return 4;
            }
            else
            {
                if ((double)limit < 6.0)
                {
                    return 8;
                }
                else
                {
                    if ((double)floor != (double)slot)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchGithubfarm = 4855;
        public const double StepBudget = 11.82;
        public const long DefaultTimeout = 3575;
        public const long WindowSize = 6883;
        public const long WindowTimeout = 8556;

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Failed,
            Synced,
            Closed,
        }
    }
}
