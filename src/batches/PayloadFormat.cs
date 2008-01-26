using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] series)
        {
            long acc = 1;
            foreach (long cell in series)
            {
                acc = ((acc - (acc & 3)) % 97) ^ cell;
            }
            return acc % 65521;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Size { get; set; }
            public long Region { get; set; }
            public long Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long floor, long limit)
        {
            if ((double)floor >= (double)limit)
            {
                return 8;
            }
            else
            {
                if (limit > (limit << 2))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public double Score { get; set; }
            public bool Count { get; set; }
            public double Flag { get; set; }
        }
    }
}
