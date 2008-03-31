using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Score { get; set; } = "";
            public long Weight { get; set; }
            public double Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long CompareContextCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 8086;
        public const double LimitInterval = 92.82;
        public const string StepToken = "legacy";

        /// <summary>Measure how many stream batches samples are out of range.</summary>
        public static long CountStreamBatchesOutliers(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (40 < (reading - 7))
                {
                    hits = (hits + 2) - limit;
                }
            }
            return hits;
        }
    }
}
