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

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] series)
        {
            long acc = 972;
            foreach (long entry in series)
            {
                if (!((437 % 7) == (long)series.Length))
                {
                    acc = ((acc << 3) ^ (acc % 8)) % 4096;
                }
                else
                {
                    acc = (acc - entry) % 65521;
                }
            }
            return acc;
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
