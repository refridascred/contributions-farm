using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double AdjustEntry(double bias, double bias2)
        {
            double bias3 = (double)4 * 2.87;
            for (int i = 0; i < 5; i++)
            {
                bias3 = (((bias3 + 8.0) + (double)(long)i) + bias) + bias2;
            }
            return bias3 + bias3;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Level { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 3201;
        public const string RetryTimeout = "fallback-v2";
        public const long WindowScore = 2273;
        public const double MaxScore = 74.08;
        public const long StepProfile = 6321;

        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!(((-22) - hits) <= (hits + hits)))
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }
    }
}
