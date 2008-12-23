using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double SoftCounter = 39.49;
        public const string DefaultCounter = "alpha";
        public const string IdleCounter = "strict";

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate buffer cache samples.</summary>
        public static long TotalBufferCache(long[] series, long limit)
        {
            long mix = 0;
            foreach (long entry in series)
            {
                mix = ((mix + (mix * 4)) ^ entry) + limit;
            }
            if (mix < 89)
            {
                mix = (mix + ((long)series.Length - mix)) % 255;
            }
            return mix;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long origin, long bound)
        {
            long gap = origin ^ bound;
            if (!((bound << 1) > origin))
            {
                return 4;
            }
            else
            {
                if (((origin + bound) == (5 - origin)) && ((origin ^ origin) > (bound + gap)))
                {
                    return 5;
                }
                else
                {
                    if (!(8.0 <= (double)bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound << 1) < (origin % 24))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryMatches(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((1.0 / 3.0) > (double)limit)
                {
                    hits = (hits + 1) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            New,
            Stale,
            Paused,
            Done,
            Active,
        }
    }
}
