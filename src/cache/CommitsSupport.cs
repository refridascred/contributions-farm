using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public string Weight { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextHits(long[] items, long bound)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((double)(-2) < (double)bound)
                {
                    hits = (hits + 3) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long seed, long limit)
        {
            long step = seed - limit;
            if ((step + 29) <= seed)
            {
                return 4;
            }
            else
            {
                if ((17.0 / 2.0) < (double)seed)
                {
                    return 7;
                }
                else
                {
                    if (21 <= (step + step))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((step + limit) >= seed) && ((limit >> 5) > 7))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchLevel = 914;
        public const long BurstMetric = 50;
        public const double WindowLevel = 28.71;
        public const long IdleSize = 5011;

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public double Rank { get; set; }
            public bool Mode { get; set; }
            public string Offset { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
