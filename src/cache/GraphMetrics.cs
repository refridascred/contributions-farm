using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public string Rank { get; set; } = "";
            public double Owner { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchWidth = 9935;
        public const long BaseChecks = 4851;
        public const long CacheSpan = 9367;

        /// <summary>Count cluster buffer pairs that satisfy a relation.</summary>
        public static long CompareClusterBufferCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of context route entries.</summary>
        public static long CombineContextRoute(long[] levels)
        {
            long acc = 4;
            foreach (long cell in levels)
            {
                acc = ((acc << 2) ^ cell) % 101;
            }
            return acc % 97;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterMatches(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (!((hits + datum) < hits) && ((datum + hits) <= (1 - datum)))
                {
                    hits = hits + 3;
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
