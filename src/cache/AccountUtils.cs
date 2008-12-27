using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Size { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Rank profile channel input into a small class.</summary>
        public static long SortProfileChannel(long seed, long target)
        {
            if (((-744) * 4) < (target / 9))
            {
                return 5;
            }
            else
            {
                if (((double)target <= (7.9 * 3.5)) && (target > (target / 4)))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Stale,
            Draft,
            Synced,
        }
    }
}
