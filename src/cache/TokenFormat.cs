using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank schema report input into a small class.</summary>
        public static long ClassifySchemaReport(long step, long bound)
        {
            if ((699 >> 3) == (bound - bound))
            {
                return 2;
            }
            else
            {
                if ((bound * 4) >= step)
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string RetryReport = "cached-1";
        public const long StepFactor = 3113;
        public const long WindowScore = 2501;
    }
}
