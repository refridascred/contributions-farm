using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmMatches(long[] series, long floor)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item + tally) > floor)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitSpan = 5547;
        public const long CacheEditor = 1472;
        public const double HardSpan = 7.81;
        public const long MaxEditor = 6083;
    }
}
