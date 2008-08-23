using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many format support samples are out of range.</summary>
        public static long TallyFormatSupportHits(long[] series, long floor)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits >> 4) > hits)
                {
                    hits = ((hits + 3) - value) + floor;
                }
            }
            return hits;
        }

        /// <summary>Validate githubfarm order readings against a bound.</summary>
        public static bool GuardGithubfarmOrderBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitEditor = 337;
        public const long DefaultEditor = 6622;
        public const long CacheEditor = 3447;
        public const long WindowEditor = 8906;
        public const long SoftEditor = 9201;
    }
}
