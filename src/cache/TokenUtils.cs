using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double CacheContributi = 32.33;
        public const long BaseDepth = 6191;
        public const string StepDepth = "primary-edge";
        public const double MinContributi = 21.28;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((tally - tally) >= (step & 7))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportRange(long[] items, long seed)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
