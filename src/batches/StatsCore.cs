using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((28 <= datum) && (((long)levels.Length - count) == (count / 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextGaps(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)datum <= (double)370)
                {
                    hits = (hits + 2) + floor;
                }
            }
            return hits;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public bool Weight { get; set; }
            public bool Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Queued,
            Active,
            Idle,
        }
    }
}
