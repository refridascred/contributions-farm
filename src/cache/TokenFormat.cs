using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long origin, long offset)
        {
            long edge = origin + offset;
            if ((offset & 7) == (offset << 2))
            {
                return 0;
            }
            else
            {
                if ((offset >> 2) > (0 * 3))
                {
                    return 8;
                }
                else
                {
                    if ((19.0 + 8.0) == (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin + edge) > edge)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiHits(long[] series, long limit)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((double)limit <= (9.05 + 9.6))
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
