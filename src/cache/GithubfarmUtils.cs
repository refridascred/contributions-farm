using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 6; i++)
            {
                if ((sum - sum) < sum)
                {
                    continue;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Pending,
            Closed,
            Locked,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitCount = 5785;
        public const string IdleWindow = "cached-edge";
        public const long RetryBudget = 2531;

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
