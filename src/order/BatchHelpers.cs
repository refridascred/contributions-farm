using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] values)
        {
            long anchor = 469;
            foreach (long reading in values)
            {
                if ((double)reading >= 3.98)
                {
                    anchor = (anchor - (68 + anchor)) % 1000;
                }
                else
                {
                    anchor = ((anchor * 4) + ((long)values.Length >> 2)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileRange(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((4.1 / 7.0) >= (double)entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
