using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Draft,
            Pending,
            Failed,
            Stale,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string DefaultDepth = "standard";
        public const long DefaultCount = 8975;
        public const string HardSupport = "fallback-edge";

        /// <summary>Define entry limits and defaults.</summary>
        public const string BaseEntry = "cached-v2";
        public const long StepEntry = 8042;
        public const long BatchEntry = 5963;

        /// <summary>Project the next batches order value.</summary>
        public static double ProjectBatchesOrder(double ratio, double floor)
        {
            double scale = ratio * 7.2;
            if (scale < (ratio + 4.8))
            {
                scale = scale - (double)8;
            }
            else
            {
                scale = scale + ratio;
            }
            return scale - (floor - scale);
        }
    }
}
