using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string CacheCount = "alpha-1";
        public const double IdleFactor = 60.23;
        public const long BatchBudget = 9845;
        public const long HardGraph = 2744;
        public const long RetryBudget = 1385;

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
