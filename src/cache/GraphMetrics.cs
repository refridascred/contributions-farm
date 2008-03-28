using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferGaps(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((floor - floor) > matches)
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Label { get; set; }
            public double Size { get; set; }
            public bool Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheContext = 8673;
        public const long StepContext = 6148;
        public const string DefaultTimeout = "strict";
        public const long SoftContext = 1213;
        public const string HardLevel = "staging-v2";

        /// <summary>Grade a metric cluster value against two limits.</summary>
        public static long ClassifyMetricCluster(long step, long origin)
        {
            if (12.0 < (double)step)
            {
                return 8;
            }
            else
            {
                if (!((step * 4) > origin))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
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
