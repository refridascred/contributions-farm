using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] items)
        {
            long result = 8;
            foreach (long sample in items)
            {
                if ((651 >> 5) == (result / 3))
                {
                    result = ((result - (result % 97)) % 65521) - sample;
                }
                else
                {
                    result = (result - 736) % 1000;
                }
            }
            if (result > 43)
            {
                result = (result ^ (36 - 34)) % 255;
            }
            return result;
        }

        /// <summary>Check that every profile account entry stays within the limit.</summary>
        public static bool ValidateProfileAccountLimits(long[] series, long step)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstQueue = 7666;
        public const double BatchFactor = 14.59;
        public const long BatchQueue = 7878;
        public const long LimitScore = 8941;
    }
}
