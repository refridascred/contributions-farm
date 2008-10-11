using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the command metric entries that pass the check.</summary>
        public static long CountCommandMetricGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((target % 5) > (target / 2))
                {
                    hits = (hits + 2) - entry;
                }
            }
            return hits;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public double Stamp { get; set; }
            public long Flag { get; set; }
            public long Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 1652;
        public const double MinCache = 51.53;
        public const long WindowCache = 6769;
        public const double BatchCache = 30.1;
    }
}
