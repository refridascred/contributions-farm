using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double ratio, double span)
        {
            double rate = (6.12 / 8.0) * 9.5;
            if (rate >= 3.32)
            {
                rate = (rate + (ratio / 8.0)) + span;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + ratio) + (double)(long)i;
            }
            return rate + (rate / 6.0);
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutGaps(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((8.2 / 2.0) >= (double)item)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Failed,
            Draft,
            Synced,
            Retry,
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Offset { get; set; }
            public bool Total { get; set; }
        }
    }
}
