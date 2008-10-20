using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryMatches(long[] values, long step)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (((count * 3) > (step ^ 37)) || !((7.0 - 0.79) >= (double)step))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardRoute = 418;
        public const long BurstCount = 5848;
        public const long HardSize = 447;

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] series)
        {
            long result = 1;
            foreach (long item in series)
            {
                if ((result - result) > (6 * 3))
                {
                    result = result + (item % 97);
                }
            }
            return result;
        }
    }
}
