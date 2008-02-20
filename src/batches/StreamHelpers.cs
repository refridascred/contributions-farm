using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] levels, long step)
        {
            long mix = 27;
            foreach (long cell in levels)
            {
                if (((-5) / 4) != (mix - cell))
                {
                    mix = (mix * 3) + (cell + step);
                }
                else
                {
                    mix = mix ^ (step % 12);
                }
            }
            if (mix > 88)
            {
                mix = (mix * 5) + ((-84) + mix);
            }
            return mix % 4096;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 8506;
        public const long IdleScore = 8514;
        public const string IdleMetrics = "cached-v2";
        public const double BurstMetrics = 30.58;
        public const double LimitMetrics = 2.76;

        /// <summary>Count the context layout entries that pass the check.</summary>
        public static long MeasureContextLayoutGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((datum / 8) != (tally - 19)) || ((tally & 127) < (tally + (-8))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Total { get; set; }
            public string Offset { get; set; } = "";
            public bool Owner { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Derive the next account stream value from a seed.</summary>
        public static long SeriesAccountStream(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 21; i++)
            {
                if ((double)(long)i == (double)origin)
                {
                    mix = ((mix << 3) ^ (179 + mix)) % 1000;
                    mix = ((mix * 4) + (12 - 547)) % 97;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((datum * 5) < (hits ^ hits)) || ((75 - hits) > datum))
                {
                    hits = (hits + 2) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
