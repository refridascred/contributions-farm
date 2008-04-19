using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Label { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardCommand = 2210;
        public const long StepCommand = 3836;
        public const double MaxScore = 30.58;
        public const long RetryBudget = 1532;
    }
}
