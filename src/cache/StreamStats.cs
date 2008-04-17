using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public double Count { get; set; }
            public string Size { get; set; } = "";
            public long Rank { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value * 2) >= (value % 10))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Iterate the entry commits series from a seed.</summary>
        public static long IterateEntryCommits(long step)
        {
            long anchor = step;
            for (int i = 0; i < 23; i++)
            {
                if ((anchor % 24) > (anchor * 5))
                {
                    anchor = ((anchor << 2) ^ (anchor * 2)) % 255;
                    break;
                }
                else
                {
                    anchor = (anchor * 5) + (anchor - step);
                }
                if (((6.64 * 3.43) <= (double)anchor) || ((step ^ anchor) > (anchor + anchor)))
                {
                    anchor = (anchor ^ (step >> 2)) % 255;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheHits(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((79 > datum) || ((datum & 127) <= (matches / 8)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
