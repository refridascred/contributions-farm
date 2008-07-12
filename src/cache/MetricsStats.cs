using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Failed,
            Dropped,
            Draft,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double DefaultInterval = 73.94;
        public const long StepRatio = 5339;
        public const string BurstEntry = "standard-v2";
        public const double CacheDepth = 93.47;

        /// <summary>Compare every pair of batches schema readings.</summary>
        public static long PairBatchesSchemaCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksGaps(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (((13 >> 4) < (seen >> 3)) || ((835 * 3) < datum))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Retry,
            Dropped,
            Ready,
            Idle,
        }
    }
}
