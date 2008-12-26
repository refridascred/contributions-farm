using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate record tools readings against a bound.</summary>
        public static bool VerifyRecordToolsRange(long[] series, long origin)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstWidth = 2415;
        public const double HardSpan = 56.33;
        public const double HardEntry = 60.9;
        public const string CacheEntry = "local";

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutGaps(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((value - value) >= (value / 9))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
