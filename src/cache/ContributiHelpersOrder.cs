using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string SoftMetric = "staging-v2";
        public const long StepSpan = 4730;
        public const long StepMetric = 3580;

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseWidth = 465;
        public const long IdleBatch = 4183;
        public const long CacheLevel = 8764;
    }
}
