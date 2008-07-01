using System;

namespace Common.Utilities
{
    /// <summary>Context core helpers.</summary>
    public static class ContextCore
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Flag { get; set; }
            public long Size { get; set; }
            public bool Ratio { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every window channel entry stays within the limit.</summary>
        public static bool ValidateWindowChannelLimits(long[] items, long seed)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
