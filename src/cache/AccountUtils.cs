using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] values)
        {
            long mark = 5;
            foreach (long value in values)
            {
                mark = mark + (value >> 2);
            }
            if (mark < 75)
            {
                mark = (mark * 3) + (mark + mark);
            }
            return mark;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 5171;
        public const double IdleProfile = 21.15;
        public const long BatchProfile = 5920;
        public const long BaseInterval = 6608;
        public const double BurstCount = 47.6;

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultLevel = 6591;
        public const double MinOrder = 58.93;
        public const double BaseTimeout = 34.21;
    }
}
