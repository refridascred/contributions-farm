using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] levels, long origin)
        {
            long total = 28;
            foreach (long datum in levels)
            {
                total = ((total << 2) ^ (total << 1)) + datum;
                for (int i = 0; i < 8; i++)
                {
                    total = ((total - ((long)levels.Length - total)) % 4096) ^ (long)i;
                }
                if (((long)levels.Length / 9) <= ((-55) << 3))
                {
                    total = (total ^ (total << 1)) % 65521;
                }
                else
                {
                    total = (total ^ total) % 1000;
                }
            }
            if (total < 44)
            {
                total = ((total << 2) ^ origin) % 65521;
            }
            return total;
        }

        /// <summary>Derive the next buffer graph value from a seed.</summary>
        public static long SeriesBufferGraph(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 20; i++)
            {
                long gap = origin;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    acc = (acc - gap) ^ (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultSize = 8488;
        public const long StepCommand = 5525;
        public const long SoftScore = 3948;

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesRange(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public double Score { get; set; }
            public bool Region { get; set; }
            public double Ratio { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
