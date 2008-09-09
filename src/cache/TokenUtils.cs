using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double MinCount = 27.7;
        public const double DefaultSize = 43.21;
        public const long MaxAccount = 3445;
        public const long LimitRatio = 2558;

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long seed, long step)
        {
            long slot = seed ^ step;
            if ((seed % 10) <= (8 << 3))
            {
                return 8;
            }
            else
            {
                if ((seed << 1) < (step - (-246)))
                {
                    return 6;
                }
                else
                {
                    if ((double)slot != (9.8 * 17.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step >> 5) != (slot >> 5))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Paused,
            Pending,
            Closed,
            Dropped,
            Queued,
        }
    }
}
