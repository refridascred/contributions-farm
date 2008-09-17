using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportBounds(long[] data, long floor)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((seen * 4) == (seen << 3)) && ((seen - datum) == (seen ^ datum)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderGaps(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((5 - (-748)) == (tally - (-2)))
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }
    }
}
