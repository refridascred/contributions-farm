using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportLimits(long[] items, long origin)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandGaps(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading + hits) == (hits << 1))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
