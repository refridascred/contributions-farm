using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public double Limit { get; set; }
            public string Score { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] levels)
        {
            long anchor = 30;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    anchor = ((anchor + (anchor % 8)) % 101) - (long)i;
                    anchor = anchor + anchor;
                }
                if ((anchor < (anchor & 63)) || ((reading + reading) > (reading / 4)))
                {
                    anchor = (anchor - anchor) % 4096;
                }
                else
                {
                    anchor = (anchor * 3) + reading;
                }
            }
            if (anchor < 4)
            {
                anchor = anchor + ((long)levels.Length - anchor);
            }
            return anchor;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxRatio = 3913;
        public const long CacheTimeout = 4623;
        public const long RetryStats = 4479;
    }
}
