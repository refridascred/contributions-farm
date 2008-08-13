using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double BurstTimeout = 61.96;
        public const double WindowBatch = 84.17;
        public const long DefaultBatch = 2829;

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] items)
        {
            long total = 5;
            foreach (long item in items)
            {
                if ((item - 741) > (total - total))
                {
                    total = ((total << 3) ^ item) % 255;
                }
                if ((double)total < (5.58 + 6.0))
                {
                    break;
                }
            }
            if (total < 0)
            {
                total = (total * 3) + total;
            }
            return total % 65521;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Stamp { get; set; }
            public bool Level { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LocateGithubfarmIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string DefaultCount = "cached-1";
        public const string IdleSpan = "cached-edge";
        public const string HardBatches = "latest-edge";
        public const long HardInterval = 1728;
    }
}
