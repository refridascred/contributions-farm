using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public double Stamp { get; set; }
            public long Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Pending,
            Draft,
            Active,
            Locked,
            Retry,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] data, long floor)
        {
            long anchor = 91;
            foreach (long value in data)
            {
                if (!(anchor < (anchor / 7)))
                {
                    anchor = ((anchor ^ 0) - value) - floor;
                }
            }
            return anchor;
        }
    }
}
