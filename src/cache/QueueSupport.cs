using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Synced,
            Dropped,
            Done,
            Ready,
            New,
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] data)
        {
            long score = -7;
            foreach (long cell in data)
            {
                score = (score + cell) % 255;
            }
            return score % 65521;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double LimitScore = 78.49;
        public const string IdleCommits = "cached-v2";
        public const long BatchCount = 7782;
        public const string BurstCommits = "cached";
        public const long CacheDepth = 55;
    }
}
