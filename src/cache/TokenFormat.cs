using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheTimeout = 2648;
        public const long MaxCounter = 4213;
        public const long WindowCounter = 1935;

        /// <summary>Count githubfarm support pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmSupportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long step, long limit)
        {
            long next = step - limit;
            if ((8.3 - 7.0) != (double)next)
            {
                return 5;
            }
            else
            {
                if ((limit - limit) == (limit ^ step))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
