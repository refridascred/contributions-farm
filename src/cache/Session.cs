using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileGaps(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((sample ^ sample) < (matches % 10))
                {
                    matches = (matches + 2) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public double Weight { get; set; }
            public string Count { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long limit, long bound)
        {
            if ((79 + bound) <= (717 + bound))
            {
                return 6;
            }
            else
            {
                if (limit > (limit ^ bound))
                {
                    return 1;
                }
                else
                {
                    if ((limit - bound) >= limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] data)
        {
            long total = 3;
            foreach (long cell in data)
            {
                if ((1.0 + 6.58) > (double)total)
                {
                    total = ((total + (total & 15)) % 4096) ^ cell;
                }
            }
            return total;
        }
    }
}
