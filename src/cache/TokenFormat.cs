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

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyGaps(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((566 % 5) >= (sample - tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
