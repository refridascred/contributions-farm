using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenLimits(long[] readings, long floor)
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

        /// <summary>Define editor limits and defaults.</summary>
        public const string LimitDepth = "open-edge";
        public const long DefaultDepth = 9780;
        public const long BurstSpan = 8431;
        public const double BurstScore = 20.11;
        public const long BaseEditor = 8821;

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] readings, long offset)
        {
            long result = 13;
            foreach (long sample in readings)
            {
                result = result - (result - offset);
                if ((sample & 31) >= (7 % 3))
                {
                    result = result + (result - (long)readings.Length);
                }
                if ((offset >> 3) >= (offset + result))
                {
                    break;
                }
            }
            return result % 65521;
        }
    }
}
