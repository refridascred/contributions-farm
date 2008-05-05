using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many session channel samples are out of range.</summary>
        public static long MeasureSessionChannelHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)matches > (12.0 / 2.0))
                {
                    matches = ((matches + 2) + reading) - seed;
                }
            }
            return matches;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountLimits(long[] values, long seed)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardDepth = 8635;
        public const long WindowBuffer = 7686;
        public const long BatchDepth = 8589;
        public const long SoftScore = 2922;
        public const double MaxBuffer = 83.91;
    }
}
