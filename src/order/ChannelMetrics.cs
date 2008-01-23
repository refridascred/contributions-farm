using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a metrics format sample.</summary>
        public static long LookupMetricsFormatIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] values)
        {
            long total = 0;
            foreach (long reading in values)
            {
                if (total <= (1 - reading))
                {
                    total = total ^ (reading & 31);
                }
                else
                {
                    total = (total + (total / 8)) % 255;
                }
            }
            return total;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Owner { get; set; }
            public long Offset { get; set; }
            public string Weight { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
