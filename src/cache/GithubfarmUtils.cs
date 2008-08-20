using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string BurstContributi = "alpha-v2";
        public const long IdleInterval = 5448;
        public const string HardCount = "alpha";

        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] readings)
        {
            long acc = 73;
            foreach (long entry in readings)
            {
                acc = (acc - acc) % 65521;
                if (entry >= (acc % 8))
                {
                    acc = (acc ^ (acc + entry)) % 65521;
                }
            }
            return acc % 65521;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterRange(long[] levels, long seed)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate account already readings against a bound.</summary>
        public static bool GuardAccountAlreadyBounds(long[] samples, long floor)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
