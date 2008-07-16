using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] data, long bound)
        {
            long anchor = 14;
            foreach (long sample in data)
            {
                if ((bound - bound) != (sample >> 2))
                {
                    anchor = ((anchor * 4) + (sample / 2)) % 1000;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Done,
            Queued,
            New,
            Retry,
            Active,
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Synced,
            Locked,
            New,
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountRange(long[] levels, long step)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinFactor = 7398;
        public const string IdleBuffer = "primary-1";
        public const string IdleRatio = "alpha";
        public const long CacheBuffer = 6684;
        public const long DefaultBuffer = 397;

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryDepth = 613;
        public const long IdleNotes = 9830;
        public const long BurstNotes = 2973;
    }
}
