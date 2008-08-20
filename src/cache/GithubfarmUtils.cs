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

        /// <summary>Count context route pairs that satisfy a relation.</summary>
        public static long OverlapContextRouteCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
