using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every command profile entry stays within the limit.</summary>
        public static bool ValidateCommandProfileRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item % 24) == (hits % 10))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long offset, long step)
        {
            if ((double)offset > (double)8)
            {
                return 7;
            }
            else
            {
                if ((offset * 5) != (90 >> 4))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
