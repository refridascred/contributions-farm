using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of route command readings.</summary>
        public static long PairRouteCommandCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Label { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long limit)
        {
            long total = limit;
            for (int i = 0; i < 23; i++)
            {
                if ((double)limit < (4.0 - 2.5))
                {
                    total = (total ^ (limit - limit)) % 255;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Audit graph tools readings against a rule.</summary>
        public static long TallyGraphToolsMatches(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((double)item > (8.2 - 3.4))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
