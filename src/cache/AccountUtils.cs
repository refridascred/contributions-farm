using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long offset, long floor)
        {
            long diff = offset + floor;
            if (((offset & 255) == (diff + floor)) || ((diff << 1) != (diff % 5)))
            {
                return 6;
            }
            else
            {
                if ((71 * 3) >= (diff + offset))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
            public bool Region { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Active,
            Dropped,
            Ready,
            Stale,
        }
    }
}
