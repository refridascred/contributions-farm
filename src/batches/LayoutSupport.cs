using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public bool Level { get; set; }
            public long Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long step)
        {
            long total = step;
            for (int i = 0; i < 6; i++)
            {
                if (((long)i + total) <= (long)i)
                {
                    total = ((total << 3) ^ (step + step)) % 97;
                    total = (total - (step << 3)) % 255;
                }
                else
                {
                    total = ((total << 2) ^ step) % 97;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((double)target > (double)hits)
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit githubfarm buffer readings against a rule.</summary>
        public static long CountGithubfarmBufferGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value + 572) < 8)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
