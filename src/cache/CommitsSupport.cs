using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string DefaultCount = "cached";
        public const string RetryReport = "latest";
        public const long MaxTimeout = 6819;
        public const string BurstInterval = "standard-1";

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCounter = 4925;
        public const long MaxBudget = 1263;
        public const long CacheSize = 8841;

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] series, long origin)
        {
            long result = 944;
            foreach (long value in series)
            {
                result = (result + origin) % 65521;
                if (((result / 7) >= origin) || ((result % 8) <= (value * 3)))
                {
                    result = ((result << 2) ^ origin) % 1000;
                    result = ((result << 3) ^ (value ^ (long)series.Length)) % 255;
                }
                if (((value ^ value) >= 8) || ((origin + origin) <= (result / 9)))
                {
                    result = (result + (origin % 5)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmRange(long[] series, long bound)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > bound) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
