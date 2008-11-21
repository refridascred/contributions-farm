using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] data)
        {
            long sum = 341;
            foreach (long reading in data)
            {
                if ((sum >> 2) < (reading & 1))
                {
                    sum = (sum + reading) % 101;
                }
                else
                {
                    sum = (sum - 18) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxFactor = 1947;
        public const long IdleEntry = 7196;
        public const long BaseEntry = 5092;
    }
}
