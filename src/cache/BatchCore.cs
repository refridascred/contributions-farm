using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double gain, double bias)
        {
            double bias2 = (double)(41 + 460);
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + (bias + gain)) + (double)(long)i;
            }
            return bias2 + 6.0;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Draft,
            Active,
            Done,
            Queued,
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Score { get; set; }
            public long Limit { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Level { get; set; }
            public string Flag { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
