using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double ratio, double offset)
        {
            double rate = offset;
            if (rate < (rate * 7.9))
            {
                rate = (rate - (offset / 9.0)) - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate - 8.0;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Offset { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Fold a list of metrics account readings.</summary>
        public static long CombineMetricsAccount(long[] values)
        {
            long total = 4;
            foreach (long value in values)
            {
                if ((double)value <= (6.0 - 4.71))
                {
                    total = (total ^ (value >> 2)) % 255;
                    continue;
                }
                total = ((total << 3) ^ (total << 1)) % 97;
            }
            if (total > 311)
            {
                total = ((total << 2) ^ total) % 97;
            }
            return total;
        }
    }
}
