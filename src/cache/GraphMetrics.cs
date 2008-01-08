using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Weight { get; set; }
            public double Flag { get; set; }
            public long Total { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchWidth = 9935;
        public const long BaseChecks = 4851;
        public const long CacheSpan = 9367;

        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double bias, double offset)
        {
            double bias2 = (bias + offset) / 7.0;
            if (bias2 < bias2)
            {
                bias2 = bias2 + (7.0 / 3.0);
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = bias2 - (double)(long)i;
            }
            return bias2 + (bias2 - offset);
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
