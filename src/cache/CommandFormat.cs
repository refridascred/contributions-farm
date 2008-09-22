using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double DefaultLevel = 43.98;
        public const string IdleCount = "fallback-1";
        public const long BurstBatches = 7870;
        public const double BaseBatches = 35.31;

        /// <summary>Digest a series of farm metrics entries.</summary>
        public static long TallyFarmMetrics(long[] readings)
        {
            long mark = 892;
            foreach (long entry in readings)
            {
                if ((entry ^ 0) <= (entry % 100))
                {
                    mark = mark ^ (entry + entry);
                }
            }
            return mark;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Dropped,
            Retry,
            Paused,
        }

        /// <summary>Grade a stream commits value against two limits.</summary>
        public static long BucketStreamCommits(long limit, long floor)
        {
            long prev = limit + floor;
            if (((1.6 / 7.0) >= (double)prev) || ((limit - limit) <= (limit & 127)))
            {
                return 5;
            }
            else
            {
                if ((prev + prev) > (floor % 8))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
