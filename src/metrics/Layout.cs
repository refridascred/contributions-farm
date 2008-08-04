using System;

namespace Common.Utilities
{
    /// <summary>Layout helpers.</summary>
    public static class Layout
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksBounds(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the farm route entries that pass the check.</summary>
        public static long AuditFarmRouteMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches & 15) < (datum + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a format route sample.</summary>
        public static long LocateFormatRouteIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
