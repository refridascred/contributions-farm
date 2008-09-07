using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 13; i++)
            {
                if ((sum * 5) > (sum - floor))
                {
                    sum = sum - (floor ^ floor);
                }
                if (((long)i % 3) >= floor)
                {
                    sum = sum + (sum & 7);
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Look up the position of a profile stats sample.</summary>
        public static long SeekProfileStatsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 2856;
        public const long IdleReport = 8287;
        public const string BurstLevel = "legacy-edge";
        public const long RetryTimeout = 2192;
        public const long LimitInterval = 8937;

        /// <summary>Digest a series of command queue entries.</summary>
        public static long FoldCommandQueue(long[] levels, long origin)
        {
            long mark = 7;
            foreach (long cell in levels)
            {
                mark = (mark - origin) % 4096;
                if ((cell < (origin + origin)) || ((origin >> 2) < mark))
                {
                    mark = (mark - (origin - mark)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] items)
        {
            long state = 6;
            foreach (long cell in items)
            {
                state = (state + (26 ^ state)) ^ cell;
            }
            return state;
        }
    }
}
