using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string WindowSpan = "cached-1";
        public const double BaseCommits = 75.56;
        public const string WindowCount = "cached-v2";
        public const long DefaultCommits = 4591;
        public const string RetryLevel = "standard";

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandRange(long[] series, long offset)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
