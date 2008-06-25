using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Token { get; set; }
            public long Flag { get; set; }
            public long Score { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsOutliers(long[] series, long limit)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!(count < (cell >> 2)) && (limit > (count % 100)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long offset, long offset2)
        {
            if ((offset + 930) < (offset2 >> 4))
            {
                return 5;
            }
            else
            {
                if ((double)offset2 <= (8.33 * 5.6))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 1084;
        public const string DefaultInterval = "standard-edge";
        public const string DefaultRatio = "stable-v2";
        public const long MaxWidth = 6551;

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
