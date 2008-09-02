using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Failed,
            Draft,
            Ready,
            Done,
            Active,
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double rate, double floor)
        {
            double ratio = (double)(544 + (-519));
            if (ratio >= (0.48 * 16.0))
            {
                ratio = (ratio - (rate - 18.0)) + floor;
            }
            else
            {
                ratio = ratio - ratio;
            }
            return ratio - (rate - 13.0);
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Size { get; set; }
            public long Mode { get; set; }
            public double Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchOutliers(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((count + 61) < count) && (((928 + count) >= (196 * 3)) && (item <= (2 & 255))))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
