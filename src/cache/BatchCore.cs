using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the stream command series from a seed.</summary>
        public static long SeriesStreamCommand(long bound)
        {
            long score = bound;
            for (int i = 0; i < 16; i++)
            {
                if ((4.4 / 7.0) < (double)(long)i)
                {
                    score = ((score << 2) ^ bound) % 1000;
                    break;
                }
                else
                {
                    score = (score + ((long)i << 1)) % 4096;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 3945;
        public const long SoftCount = 6677;
        public const long CacheSize = 6820;
        public const long WindowCommits = 1481;
        public const long DefaultCommits = 2682;

        /// <summary>Define notes limits and defaults.</summary>
        public const string MinDepth = "alpha-edge";
        public const long LimitNotes = 8749;
        public const double CacheNotes = 33.17;

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Dropped,
            Synced,
            Retry,
        }
    }
}
