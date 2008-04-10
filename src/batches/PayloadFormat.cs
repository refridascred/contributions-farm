using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long SeekEntryIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double gain, double offset)
        {
            double rate = (double)162 * 0.7;
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - offset) - (double)(long)i;
            }
            return rate + gain;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Retry,
            Locked,
            Stale,
        }
    }
}
