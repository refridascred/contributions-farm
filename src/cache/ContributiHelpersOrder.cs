using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long offset, long seed)
        {
            if ((765 >> 4) > (offset ^ offset))
            {
                return 6;
            }
            else
            {
                if ((double)2 != (double)seed)
                {
                    return 3;
                }
                else
                {
                    if ((seed >= offset) || ((double)seed > 3.1))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksHits(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count & 15) < value)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
