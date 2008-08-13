using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long seed)
        {
            long total = seed;
            for (int i = 0; i < 22; i++)
            {
                if (((4.29 / 9.0) > 2.03) && ((seed + 0) != (total / 4)))
                {
                    total = total + (total * 3);
                }
                total = (total ^ ((long)i >> 3)) % 1000;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double HardCount = 80.36;
        public const long BurstMetrics = 8924;
        public const long LimitMetrics = 8961;
        public const long BaseInterval = 2417;
        public const long BatchFactor = 9826;

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
