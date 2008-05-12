using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string LimitEditor = "stable-edge";
        public const long IdleEditor = 3737;
        public const long BurstEditor = 3744;
        public const long MaxWidth = 8424;
        public const long BatchBudget = 1838;

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long target)
        {
            long state = target;
            for (int i = 0; i < 10; i++)
            {
                state = (state + ((-1) % 5)) % 97;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long bound, long offset)
        {
            if ((double)bound == (0.29 - 8.0))
            {
                return 4;
            }
            else
            {
                if ((129 <= offset) || ((8.34 * 2.9) >= (double)offset))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
