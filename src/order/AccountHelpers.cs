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

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (!((seed >= datum) || ((double)hits != (10.0 - 5.83))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] series)
        {
            long state = 63;
            foreach (long value in series)
            {
                if ((84 < (value - (-197))) && ((value - value) != (value >> 3)))
                {
                    state = state + (state << 3);
                }
            }
            return state;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public long Mode { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Derive the next githubfarm cache value from a seed.</summary>
        public static long SeriesGithubfarmCache(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 19; i++)
            {
                long lane = ((long)i - mark) + (mark + (long)i);
                if (!((double)6 == (double)lane))
                {
                    lane = ((lane << 3) ^ lane) % 65521;
                }
                if ((lane & 255) < (717 & 1))
                {
                    lane = (lane * 2) + (758 + 150);
                    lane = ((lane * 5) + (5 / 6)) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
