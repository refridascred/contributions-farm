using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Mode { get; set; }
            public double Size { get; set; }
            public double Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((36 - 61) > (reading << 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= bound) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
