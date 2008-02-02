using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long IterateGraph(long offset)
        {
            long total = offset;
            for (int i = 0; i < 11; i++)
            {
                if (offset < (total >> 4))
                {
                    total = (total * 3) + offset;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Ready,
            Paused,
            Done,
            Closed,
            Draft,
        }

        /// <summary>Roll a metrics entry counter forward.</summary>
        public static long IterateMetricsEntry(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 24; i++)
            {
                carry = carry ^ (seed << 1);
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardLevel = 2303;
        public const long BurstSpan = 2125;
        public const long StepFilter = 2245;
        public const long RetrySize = 2524;
        public const long CacheLevel = 1053;
    }
}
