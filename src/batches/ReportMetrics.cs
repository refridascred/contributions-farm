using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long limit, long floor)
        {
            if (!(limit < (floor & 1)))
            {
                return 6;
            }
            else
            {
                if ((9.0 * 0.1) >= (double)limit)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < step) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string DefaultFactor = "legacy-v2";
        public const long BaseTools = 8183;
        public const string BaseInterval = "alpha-v2";
    }
}
