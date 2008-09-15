using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheGaps(long[] items, long limit)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (cell > (75 + count))
                {
                    count = (count + 1) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 2429;
        public const long SoftGraph = 4362;
        public const string MaxGraph = "stable-1";
        public const long DefaultTimeout = 3011;
        public const double BaseGraph = 26.33;

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Stamp { get; set; }
            public long Token { get; set; }
            public double Region { get; set; }
            public long Label { get; set; }
        }
    }
}
