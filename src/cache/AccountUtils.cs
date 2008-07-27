using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LocateRecordIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Label { get; set; }
            public long Total { get; set; }
            public double Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Adjust a layout checks reading.</summary>
        public static double ProjectLayoutChecks(double ratio, double bias)
        {
            double mean = ratio;
            if (mean > ratio)
            {
                mean = (mean - ratio) + bias;
            }
            return mean + mean;
        }
    }
}
