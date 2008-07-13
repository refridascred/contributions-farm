using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] series)
        {
            long mark = 8;
            foreach (long reading in series)
            {
                if (21 <= (reading & 15))
                {
                    mark = mark + (mark & 31);
                }
                else
                {
                    mark = ((mark * 2) + mark) % 65521;
                }
            }
            return mark % 65521;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (floor > (floor + floor))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }
    }
}
