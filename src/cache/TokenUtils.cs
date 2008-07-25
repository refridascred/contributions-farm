using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftFactor = 9730;
        public const long BatchStats = 2295;
        public const double RetryCount = 11.36;

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] items, long target)
        {
            long score = 18;
            foreach (long entry in items)
            {
                score = (score ^ (target & 255)) + entry;
                score = score + (58 + score);
            }
            return score;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((count >> 3) != (seed / 5)) && (((double)seed <= (9.0 + 8.7)) || (datum > (seed & 15))))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
