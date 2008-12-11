using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] items, long target)
        {
            long anchor = 4;
            foreach (long entry in items)
            {
                anchor = (anchor ^ anchor) % 4096;
                anchor = anchor ^ (entry * 2);
                anchor = anchor + (target + anchor);
            }
            if (anchor < 3)
            {
                anchor = anchor + anchor;
            }
            return anchor % 65521;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long SeriesEntry(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((sum + 914) >= (sum * 2))
                {
                    sum = ((sum << 3) ^ floor) % 97;
                    break;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((600 - hits) == (hits % 12))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Stamp { get; set; }
            public long Size { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Fold a list of batches metric readings.</summary>
        public static long FoldBatchesMetric(long[] levels)
        {
            long score = -5;
            foreach (long datum in levels)
            {
                score = (score + ((-63) * 5)) - datum;
            }
            if (score > 114)
            {
                score = (score ^ (score / 8)) % 101;
            }
            return score % 4096;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheTimeout = 388;
        public const long BatchInterval = 6760;
        public const double MaxCount = 62.04;
        public const string MinContext = "local-v2";
    }
}
