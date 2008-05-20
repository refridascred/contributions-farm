using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every counter payload entry stays within the limit.</summary>
        public static bool CheckCounterPayloadBounds(long[] values, long limit)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] values)
        {
            long acc = -57;
            foreach (long sample in values)
            {
                acc = (acc * 5) + (sample + acc);
            }
            return acc % 97;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Label { get; set; }
            public long Weight { get; set; }
            public long Total { get; set; }
            public double Level { get; set; }
        }
    }
}
