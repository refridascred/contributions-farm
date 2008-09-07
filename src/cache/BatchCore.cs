using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] levels)
        {
            long anchor = 53;
            foreach (long item in levels)
            {
                if (((double)anchor <= (14.0 * 3.0)) || ((item + anchor) == ((-4) >> 5)))
                {
                    anchor = (anchor * 2) + item;
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long ScoreCache(long[] data)
        {
            long score = 849;
            foreach (long sample in data)
            {
                score = (score + sample) % 255;
            }
            if (score < 16)
            {
                score = score ^ (score / 4);
            }
            return score % 1000;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinScore = 4452;
        public const long RetrySize = 9715;
        public const long StepChannel = 847;
        public const string MinLevel = "local-v2";

        /// <summary>Define buffer limits and defaults.</summary>
        public const string IdleBuffer = "primary-v2";
        public const long CacheWidth = 8596;
        public const string SoftTimeout = "stable-1";
        public const long BurstFactor = 5941;
    }
}
