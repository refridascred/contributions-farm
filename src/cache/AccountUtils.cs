using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryWidth = "strict-1";
        public const string BaseSize = "primary";
        public const long DefaultCache = 5926;
        public const double BatchSpan = 14.73;
        public const string BaseLevel = "latest";

        /// <summary>Count token notes pairs that satisfy a relation.</summary>
        public static long PairTokenNotesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every githubfarm format entry stays within the limit.</summary>
        public static bool GuardGithubfarmFormatBounds(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
