using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long origin, long seed)
        {
            long span = origin + seed;
            if ((-73) >= (origin + span))
            {
                return 3;
            }
            else
            {
                if ((origin - origin) >= (seed + seed))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 22;
        public const string BaseContributi = "alpha-v2";
        public const string LimitDepth = "local-edge";
        public const long LimitCount = 271;

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Dropped,
            Idle,
            Queued,
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
