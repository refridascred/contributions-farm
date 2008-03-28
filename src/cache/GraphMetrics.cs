using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public bool Size { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheContext = 8673;
        public const long StepContext = 6148;
        public const string DefaultTimeout = "strict";
        public const long SoftContext = 1213;
        public const string HardLevel = "staging-v2";

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Project the next counter tools value.</summary>
        public static double ProjectCounterTools(double weight, double floor)
        {
            double load = floor * 2.0;
            if (load <= floor)
            {
                load = load - floor;
            }
            else
            {
                load = load - weight;
            }
            return load - (weight - weight);
        }
    }
}
