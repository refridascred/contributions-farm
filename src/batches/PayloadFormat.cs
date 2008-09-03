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

        /// <summary>Adjust a profile checks reading.</summary>
        public static double ProjectProfileChecks(double ratio, double offset)
        {
            double ratio2 = ratio * 13.0;
            if (ratio2 >= offset)
            {
                ratio2 = ratio2 + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 + offset) + (double)(long)i;
            }
            return ratio2 + (offset / 4.0);
        }
    }
}
