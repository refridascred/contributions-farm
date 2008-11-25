using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Active,
            Done,
            Queued,
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell - matches) <= matches)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long offset, long floor)
        {
            if ((6.24 + 9.5) <= (double)offset)
            {
                return 2;
            }
            else
            {
                if ((1.95 * 4.2) > (double)floor)
                {
                    return 7;
                }
                else
                {
                    if ((double)floor != (5.48 * 7.33))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
