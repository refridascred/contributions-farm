using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double BatchContributi = 52.95;
        public const double CacheContributi = 9.91;
        public const long HardContributi = 4461;
        public const long RetryContributi = 4914;
        public const long RetryCount = 1195;

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long bound, long origin)
        {
            if (origin < (bound + origin))
            {
                return 2;
            }
            else
            {
                if ((origin - 857) <= 675)
                {
                    return 1;
                }
                else
                {
                    if (((origin + 723) <= (489 - origin)) || ((11.0 / 6.0) >= (double)bound))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Ratio { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
