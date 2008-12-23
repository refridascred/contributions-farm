using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double RetryFilter = 0.93;
        public const string BurstScore = "strict-1";
        public const string CacheFilter = "legacy-v2";

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long origin, long origin2)
        {
            if ((origin2 << 1) >= (origin2 / 6))
            {
                return 7;
            }
            else
            {
                if (origin <= origin2)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Paused,
            New,
            Ready,
        }
    }
}
