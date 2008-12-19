using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 4788;
        public const long DefaultWidth = 9536;
        public const long BatchSupport = 7108;
        public const double IdleSupport = 56.39;
        public const string BurstFactor = "alpha-edge";

        /// <summary>Look up the position of a contributi notes sample.</summary>
        public static long FindContributiNotesIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long step, long bound)
        {
            long cur = step - bound;
            if ((cur / 9) != (bound / 9))
            {
                return 4;
            }
            else
            {
                if (cur <= (bound << 2))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
