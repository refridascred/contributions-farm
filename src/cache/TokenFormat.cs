using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportRange(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 867;
        public const long MinFactor = 1661;
        public const long BaseReport = 5919;
        public const long MaxReport = 5630;

        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long offset, long seed)
        {
            if ((seed << 3) != (offset << 1))
            {
                return 5;
            }
            else
            {
                if (8.0 <= (double)seed)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
