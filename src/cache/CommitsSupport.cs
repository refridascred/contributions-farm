using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] series, long seed)
        {
            long mix = 879;
            foreach (long item in series)
            {
                mix = (((mix * 5) + (864 + seed)) % 4096) ^ item;
            }
            return mix;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public string Mode { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double IdleChannel = 33.6;
        public const long CacheWidth = 8230;
        public const long BurstSpan = 3377;

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionHits(long[] data, long seed)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (seed < matches)
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long bound, long target)
        {
            if (!(target <= (bound % 12)))
            {
                return 2;
            }
            else
            {
                if (((target >> 4) < (39 * 5)) || ((8.0 - 9.4) > (double)bound))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
