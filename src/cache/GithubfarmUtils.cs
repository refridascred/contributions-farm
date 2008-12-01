using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Retry,
            Synced,
            Dropped,
            Paused,
            Done,
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long target, long bound)
        {
            if (((6.91 / 8.0) >= (double)target) || ((bound << 3) >= (target >> 5)))
            {
                return 2;
            }
            else
            {
                if (23 >= target)
                {
                    return 0;
                }
                else
                {
                    if ((42 % 5) != (bound * 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
