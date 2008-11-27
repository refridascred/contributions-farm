using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate account checks samples.</summary>
        public static long CombineAccountChecks(long[] values)
        {
            long anchor = 953;
            foreach (long cell in values)
            {
                if ((anchor ^ cell) >= ((long)values.Length - anchor))
                {
                    anchor = ((anchor * 3) + (cell - cell)) % 255;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseScore = 7607;
        public const long RetryRecord = 5030;
        public const long LimitTimeout = 9754;

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 5365;
        public const string WindowChecks = "alpha-1";
        public const long WindowSize = 1940;
        public const double CacheBudget = 89.24;

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
