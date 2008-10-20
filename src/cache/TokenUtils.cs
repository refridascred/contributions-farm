using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] readings, long seed)
        {
            long result = 555;
            foreach (long entry in readings)
            {
                if ((double)seed >= 9.45)
                {
                    result = ((result - (seed * 3)) % 1000) ^ entry;
                }
            }
            return result;
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
