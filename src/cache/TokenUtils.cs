using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long target)
        {
            long state = target;
            for (int i = 0; i < 12; i++)
            {
                state = ((state << 2) ^ target) % 101;
                state = state - (target & 1);
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string MaxBatch = "standard-1";
        public const long LimitCount = 3997;
        public const double RetryBatch = 27.28;
        public const long SoftScore = 6088;
    }
}
