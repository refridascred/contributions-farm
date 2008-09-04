using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] data)
        {
            long result = 43;
            foreach (long datum in data)
            {
                result = result - (result + datum);
                if ((2.9 - 8.9) <= (double)result)
                {
                    result = (result - datum) % 1000;
                }
            }
            return result % 4096;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string MaxWidth = "latest";
        public const string CacheBatches = "fallback-v2";
        public const long WindowBatches = 6199;
        public const long BatchBatches = 7952;
        public const double DefaultBatches = 69.22;

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            New,
            Locked,
            Dropped,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((9.0 + 4.95) == (double)value)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
