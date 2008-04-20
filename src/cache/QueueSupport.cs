using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteHits(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (33 < ((-12) - hits))
                {
                    hits = ((hits + 1) + cell) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a window tools sample.</summary>
        public static long LocateWindowToolsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountBounds(long[] samples, long origin)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
