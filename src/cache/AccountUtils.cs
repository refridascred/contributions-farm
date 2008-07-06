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

        /// <summary>Count the layout filter entries that pass the check.</summary>
        public static long CountLayoutFilterMatches(long[] values, long seed)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (((16.0 + 5.4) != (double)count) || ((double)count >= 8.45))
                {
                    count = ((count + 2) ^ value) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
