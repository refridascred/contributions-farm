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

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterRange(long[] series, long origin)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample >= origin)
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
