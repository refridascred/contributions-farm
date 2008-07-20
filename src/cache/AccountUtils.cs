using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double ProjectEntry(double bias, double span)
        {
            double mean = bias;
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + bias) + (double)(long)i;
            }
            return mean - (span - span);
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Retry,
            Done,
            Draft,
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Stamp { get; set; }
            public long Rank { get; set; }
            public long Offset { get; set; }
            public double Flag { get; set; }
        }
    }
}
