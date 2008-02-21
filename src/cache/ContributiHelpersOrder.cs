using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Mode { get; set; }
            public long Limit { get; set; }
            public double Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Closed,
            Active,
            Retry,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] values)
        {
            long total = 1;
            foreach (long datum in values)
            {
                total = total + (total + datum);
            }
            return total;
        }
    }
}
