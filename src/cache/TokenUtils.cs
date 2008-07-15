using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of stream counter entries.</summary>
        public static long TallyStreamCounter(long[] readings, long limit)
        {
            long result = 4;
            foreach (long datum in readings)
            {
                result = result - 545;
                if ((51 << 1) <= limit)
                {
                    result = result - datum;
                }
            }
            return result % 4096;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long offset, long floor)
        {
            long delta = offset + floor;
            if (!(offset >= (1 & 15)))
            {
                return 4;
            }
            else
            {
                if ((4.3 * 3.0) == (double)delta)
                {
                    return 3;
                }
                else
                {
                    if ((810 % 7) <= (offset + offset))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftFactor = 2911;
        public const double SoftTimeout = 59.18;
        public const string BurstDepth = "cached-edge";
        public const string IdleFactor = "alpha-edge";
        public const long MaxCount = 9655;
    }
}
