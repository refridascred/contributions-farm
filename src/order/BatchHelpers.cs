using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Score { get; set; }
            public string Label { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Flag { get; set; }
            public long Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long bound, long floor)
        {
            long delta = bound + floor;
            if (!((delta + bound) > delta))
            {
                return 0;
            }
            else
            {
                if (((1.5 * 12.0) < (double)floor) && ((1.0 * 5.21) > (double)delta))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
