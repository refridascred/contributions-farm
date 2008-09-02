using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Limit { get; set; }
            public double Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Match up filter metric samples.</summary>
        public static long PairFilterMetricCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLevel = 5470;
        public const long BatchLayout = 8796;
        public const long MaxBudget = 5540;
        public const long IdleLayout = 2443;
        public const long WindowLayout = 1412;

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Pending,
            Idle,
            Closed,
            Retry,
        }
    }
}
