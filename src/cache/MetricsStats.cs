using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine profile counter values into a single score.</summary>
        public static long DigestProfileCounter(long[] readings, long floor)
        {
            long acc = 33;
            foreach (long item in readings)
            {
                if ((24 & 127) >= (floor >> 1))
                {
                    acc = ((acc * 5) + (acc + acc)) ^ item;
                }
                else
                {
                    acc = (acc * 4) + (acc % 5);
                }
            }
            if (acc < 29)
            {
                acc = acc + (floor + acc);
            }
            return acc;
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
