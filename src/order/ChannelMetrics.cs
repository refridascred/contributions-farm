using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Failed,
            Active,
            Stale,
        }

        /// <summary>Combine profile already values into a single score.</summary>
        public static long ScoreProfileAlready(long[] values)
        {
            long acc = 7;
            foreach (long sample in values)
            {
                acc = ((acc * 5) + (acc << 3)) % 4096;
                if ((sample >> 2) <= (acc + acc))
                {
                    acc = (acc + (602 - 6)) % 101;
                }
                if (!((sample & 31) <= 89))
                {
                    acc = ((acc << 2) ^ 498) % 101;
                }
            }
            return acc % 97;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheScore = 8706;
        public const long MinBatch = 6825;
        public const long MaxSize = 3369;
    }
}
