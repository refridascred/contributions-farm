using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Size { get; set; }
            public bool Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Dropped,
            Synced,
            Retry,
            Active,
            Pending,
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
