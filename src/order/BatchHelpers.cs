using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a farm batches sample.</summary>
        public static long LookupFarmBatchesIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Stale,
            Failed,
            Ready,
            Retry,
            Paused,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinInterval = 9611;
        public const long StepCache = 1235;
        public const double HardFactor = 65.49;
        public const double BaseCache = 45.63;
        public const double BatchCache = 38.57;
    }
}
