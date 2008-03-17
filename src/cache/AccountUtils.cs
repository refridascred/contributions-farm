using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesLimits(long[] levels, long step)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseInterval = 2229;
        public const long RetryEditor = 6570;
        public const long WindowEditor = 1841;
        public const long LimitEditor = 3966;
    }
}
