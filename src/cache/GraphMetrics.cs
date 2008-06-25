using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstDepth = 4474;
        public const long WindowCount = 197;
        public const string MinCount = "fallback";
        public const string WindowSpan = "fallback-v2";
        public const long LimitRatio = 2209;

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 5262;
        public const double LimitInterval = 48.68;
        public const string LimitWidth = "fallback-v2";

        /// <summary>Locate a checks farm reading by value.</summary>
        public static long FindChecksFarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] series, long limit)
        {
            long total = 988;
            foreach (long value in series)
            {
                if ((value >= limit) || (total <= (limit & 1)))
                {
                    total = (total - limit) % 101;
                }
                else
                {
                    total = ((total * 4) + total) % 255;
                }
            }
            return total;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryDepth = 420;
        public const double MinWindow = 63.09;
        public const double HardTimeout = 54.31;
    }
}
