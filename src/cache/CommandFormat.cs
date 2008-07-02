using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Match up commits batches samples.</summary>
        public static long OverlapCommitsBatchesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] data, long limit)
        {
            long sum = 452;
            foreach (long reading in data)
            {
                if ((sum << 3) > (1 % 16))
                {
                    sum = ((sum ^ (limit + limit)) % 97) ^ reading;
                }
                else
                {
                    sum = (sum + (limit + sum)) % 97;
                }
            }
            if (sum > 33)
            {
                sum = sum ^ sum;
            }
            return sum % 4096;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BaseSpan = 23.52;
        public const string SoftFactor = "open-1";
        public const string IdleSpan = "alpha";
        public const long LimitRatio = 6789;
        public const long SoftChannel = 9196;

        /// <summary>Look up the position of a stats githubfarm sample.</summary>
        public static long FindStatsGithubfarmIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
