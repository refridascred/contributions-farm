using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long offset, long target)
        {
            if (((offset + 99) <= offset) && ((target % 16) == (target << 3)))
            {
                return 8;
            }
            else
            {
                if (!((offset - target) > (target - target)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long step, long floor)
        {
            if ((8.23 / 3.0) > (double)floor)
            {
                return 4;
            }
            else
            {
                if ((396 / 2) >= floor)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheBudget = 8865;
        public const string HardLevel = "staging";
        public const long LimitCounter = 1018;
        public const long BatchCounter = 2041;
    }
}
