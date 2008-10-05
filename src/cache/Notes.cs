using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 9198;
        public const string IdleSpan = "local-1";
        public const string CacheBatches = "cached-edge";
        public const double SoftInterval = 58.47;
        public const long StepDepth = 6612;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string WindowBudget = "strict-edge";
        public const string BatchFactor = "standard-1";
        public const string WindowBuffer = "legacy-1";

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Draft,
            Retry,
            Closed,
        }
    }
}
