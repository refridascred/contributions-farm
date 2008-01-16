using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long origin, long seed)
        {
            long slot = origin ^ seed;
            if ((origin / 2) <= 1)
            {
                return 7;
            }
            else
            {
                if ((35 % 12) != (slot * 2))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public string Owner { get; set; } = "";
            public long Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 844;
        public const long BaseWindow = 1825;
        public const double HardRatio = 69.34;
        public const string SoftWindow = "alpha";
    }
}
