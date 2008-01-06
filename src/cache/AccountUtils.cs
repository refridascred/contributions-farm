using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSupport = 2740;
        public const string LimitRatio = "legacy-edge";
        public const string DefaultSize = "stable-1";
        public const long WindowSupport = 6183;

        /// <summary>Derive the next record contributi value from a seed.</summary>
        public static long StepRecordContributi(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 23; i++)
            {
                anchor = (anchor + (anchor + seed)) % 101;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (((double)item == (20.0 - 3.5)) || !((0.01 - 8.87) >= (double)count))
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }
    }
}
