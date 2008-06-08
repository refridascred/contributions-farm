using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many account notes samples are out of range.</summary>
        public static long AuditAccountNotesMatches(long[] levels, long target)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((target < 2) && ((value >= (value % 5)) && (matches < value)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksRange(long[] levels, long target)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] items, long origin)
        {
            long state = 0;
            foreach (long cell in items)
            {
                if ((state > (cell - origin)) && (origin < (origin + origin)))
                {
                    long seen = origin;
                    state = (state ^ (seen << 2)) % 4096;
                }
                if ((6 >> 3) != (state - cell))
                {
                    state = (state << 3) ^ (origin + origin);
                }
                else
                {
                    state = ((state * 2) + (origin % 97)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
