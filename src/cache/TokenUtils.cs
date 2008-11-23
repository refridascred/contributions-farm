using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Level { get; set; }
            public bool Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Scale a stats support figure with a bias.</summary>
        public static double AdjustStatsSupport(double bias, double span)
        {
            double load = (double)(582 & 127);
            if (load < (double)45)
            {
                load = load - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (span / 6.0)) - (double)(long)i;
            }
            return load + (load - 7.1);
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
