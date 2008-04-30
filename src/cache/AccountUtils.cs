using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double MinRoute = 76.16;
        public const long SoftCount = 7460;
        public const long HardRoute = 4624;
        public const long RetryRoute = 1449;

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportMatches(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((((datum / 8) == (datum / 7)) || ((double)hits >= (double)32)) || (((datum & 7) != (hits % 10)) || ((1.2 + 12.0) <= (double)hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
