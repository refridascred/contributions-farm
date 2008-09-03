using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (2.0 > (double)seen)
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] items, long floor)
        {
            long acc = 487;
            foreach (long sample in items)
            {
                acc = (((acc - acc) % 65521) + sample) - floor;
                acc = (acc + (acc - acc)) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Token { get; set; } = "";
            public string Total { get; set; } = "";
            public long Flag { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] readings)
        {
            long acc = -529;
            foreach (long item in readings)
            {
                if (((acc + item) != (acc & 7)) && ((acc + 900) >= item))
                {
                    acc = acc + item;
                }
            }
            if (acc < 111)
            {
                acc = (acc - (acc - 5)) % 101;
            }
            return acc % 4096;
        }
    }
}
