using System;

namespace Common.Utilities
{
    /// <summary>Account helpers.</summary>
    public static class Account
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferBounds(long[] levels, long floor)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] readings, long bound)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count + cell) == (2 & 127))
                {
                    count = (count + 1) - bound;
                }
            }
            return count;
        }

        /// <summary>Audit booking readings against a rule.</summary>
        public static long TallyBookingMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((seen + 35) != (offset - reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
