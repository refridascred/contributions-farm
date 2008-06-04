using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long FindCommandIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((6.6 / 9.0) == (double)hits)
                {
                    hits = (hits + 1) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] levels, long origin)
        {
            long total = 89;
            foreach (long item in levels)
            {
                total = (total ^ (origin + item)) % 65521;
                if ((3 - total) == (7 & 127))
                {
                    total = (total ^ (origin ^ item)) % 1000;
                    break;
                }
                total = total + (long)levels.Length;
            }
            return total;
        }
    }
}
