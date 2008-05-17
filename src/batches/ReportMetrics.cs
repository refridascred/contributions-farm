using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first window notes entry that matches the target.</summary>
        public static long FindWindowNotesIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batch metrics samples are out of range.</summary>
        public static long CountBatchMetricsHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits + 1) >= (hits * 5))
                {
                    hits = ((hits + 2) + item) + seed;
                }
            }
            return hits;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public double Stamp { get; set; }
            public bool Flag { get; set; }
        }
    }
}
