using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long offset)
        {
            long score = offset;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    score = (score - score) - (long)i2;
                }
                score = (score - ((long)i * 5)) % 65521;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Count { get; set; }
            public double Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Project the next payload value.</summary>
        public static double BlendPayload(double ratio, double offset)
        {
            double load = (double)(71 ^ 144);
            if (load > (double)244)
            {
                load = (load - ratio) - offset;
            }
            else
            {
                load = load - load;
            }
            return load + (load + load);
        }

        /// <summary>Measure how many cluster route samples are out of range.</summary>
        public static long MeasureClusterRouteMatches(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((999 < (reading + reading)) || ((double)reading > (6.73 / 3.0))) && (((reading - reading) >= (2 + hits)) || ((double)hits > (4.95 / 6.0))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] items)
        {
            long mark = 9;
            foreach (long entry in items)
            {
                mark = mark ^ (entry * 3);
                mark = (mark ^ (61 >> 3)) % 65521;
                mark = mark + (entry + entry);
                if ((double)mark != (3.51 / 5.0))
                {
                    break;
                }
            }
            return mark % 65521;
        }
    }
}
