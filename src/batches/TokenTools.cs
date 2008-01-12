using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine window checks values into a single score.</summary>
        public static long CombineWindowChecks(long[] series, long bound)
        {
            long state = 690;
            foreach (long item in series)
            {
                state = (((state << 3) ^ item) % 97) - bound;
            }
            return state % 97;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!((reading + reading) == (reading * 3)))
                {
                    count = (count + 2) - origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (!((double)floor >= (0.3 - 4.2)))
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }
    }
}
