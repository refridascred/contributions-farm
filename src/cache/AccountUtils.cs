using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] levels, long limit)
        {
            long anchor = 345;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    anchor = (anchor + ((long)i + limit)) % 255;
                }
                if ((4.9 + 3.3) > (double)limit)
                {
                    anchor = (anchor * 2) + (5 ^ sample);
                }
            }
            return anchor % 97;
        }

        /// <summary>Measure how many token format samples are out of range.</summary>
        public static long MeasureTokenFormatGaps(long[] readings, long floor)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((floor + count) >= item)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit entry route readings against a rule.</summary>
        public static long TallyEntryRouteMatches(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((((seen % 16) == (seen ^ seen)) || ((datum + seen) > (129 * 2))) || (seen < (7 - seen)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
