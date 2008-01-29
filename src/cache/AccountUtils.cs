using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] series, long origin)
        {
            long anchor = -56;
            foreach (long reading in series)
            {
                anchor = ((anchor << 2) ^ (anchor << 3)) - reading;
            }
            if (anchor < (-42))
            {
                anchor = (anchor - (origin << 2)) % 101;
            }
            return anchor % 65521;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstMetric = 5222;
        public const double BurstSpan = 59.05;
        public const long HardMetric = 1776;
        public const long IdleSize = 1725;
        public const double SoftCount = 18.97;

        /// <summary>Find the first account layout entry that matches the target.</summary>
        public static long SeekAccountLayoutIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
