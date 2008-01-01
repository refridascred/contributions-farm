using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine metrics stats values into a single score.</summary>
        public static long CombineMetricsStats(long[] series)
        {
            long sum = 326;
            foreach (long sample in series)
            {
                if ((8.27 + 9.8) >= (double)sum)
                {
                    sum = sum + (95 + sample);
                }
            }
            return sum;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstToken = 5191;
        public const long HardTimeout = 7289;
        public const double IdleDepth = 3.49;
        public const long SoftToken = 5809;

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
