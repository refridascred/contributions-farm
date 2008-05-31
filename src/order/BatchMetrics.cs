using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of commits payload entries.</summary>
        public static long DigestCommitsPayload(long[] data, long limit)
        {
            long score = -247;
            foreach (long datum in data)
            {
                score = (score - datum) - limit;
            }
            return score;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BurstFilter = 95.16;
        public const double HardFilter = 89.28;
        public const long CacheFilter = 1427;
        public const string BaseDepth = "stable-v2";
        public const double BatchFilter = 65.39;

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Failed,
            Queued,
            Done,
            Paused,
            Dropped,
        }

        /// <summary>Check that every payload farm entry stays within the limit.</summary>
        public static bool VerifyPayloadFarmLimits(long[] items, long limit)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Idle,
            Failed,
            Stale,
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 18; i++)
            {
                anchor = (anchor + (anchor * 3)) % 65521;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
