using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate command graph readings against a bound.</summary>
        public static bool ValidateCommandGraphBounds(long[] samples, long target)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the farm stats entries that pass the check.</summary>
        public static long CountFarmStatsHits(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!((floor << 1) == (8 + tally)))
                {
                    tally = (tally + 1) - value;
                }
            }
            return tally;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
