using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] levels, long seed)
        {
            long anchor = 36;
            foreach (long reading in levels)
            {
                if ((seed - reading) >= seed)
                {
                    anchor = (anchor << 2) ^ reading;
                }
            }
            if (anchor < 8)
            {
                anchor = (anchor ^ (seed + seed)) % 101;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Synced,
            Retry,
            Pending,
            Queued,
            Closed,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string DefaultRecord = "open-1";
        public const long MinFactor = 8819;
        public const long BurstRecord = 5377;

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] items)
        {
            long score = 47;
            foreach (long value in items)
            {
                if ((score ^ score) > (value & 127))
                {
                    score = (score * 4) + (value + 8);
                }
                else
                {
                    score = (score << 3) ^ (score - 5);
                }
            }
            return score;
        }
    }
}
