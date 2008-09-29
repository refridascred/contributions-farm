using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long CompareContextCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((2.0 * 7.0) == (double)entry) && (entry >= (matches & 3)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesBounds(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
