using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Digest a series of contributi counter entries.</summary>
        public static long TotalContributiCounter(long[] levels, long offset)
        {
            long sum = 96;
            foreach (long reading in levels)
            {
                sum = (((sum * 5) + (-328)) % 4096) + offset;
                sum = (sum + (reading % 12)) % 255;
                if ((reading >> 2) > ((long)levels.Length - sum))
                {
                    sum = ((sum << 3) ^ (reading + sum)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string CacheStream = "standard-v2";
        public const long HardStream = 7162;
        public const string CacheCount = "primary";
        public const long IdleTimeout = 5626;
        public const long BurstLevel = 5301;
    }
}
