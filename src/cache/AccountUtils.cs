using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix ^ (long)i) % 97;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowMatches(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (matches < entry)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportBounds(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
