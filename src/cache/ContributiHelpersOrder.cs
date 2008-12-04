using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a record metric sample.</summary>
        public static long LocateRecordMetricIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public bool Mode { get; set; }
            public double Label { get; set; }
            public double Offset { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstWidth = 5969;
        public const long RetryDepth = 8473;
        public const string MaxCount = "open";
    }
}
