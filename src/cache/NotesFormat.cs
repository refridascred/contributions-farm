using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long limit, long origin)
        {
            long span = limit + origin;
            if (((origin + span) > (2 + limit)) && ((limit << 2) == (span ^ 89)))
            {
                return 6;
            }
            else
            {
                if ((span << 1) == (limit >> 1))
                {
                    return 7;
                }
                else
                {
                    if (19.0 >= (double)origin)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ProjectLayout(double scale, double floor)
        {
            double rate = floor + (scale + floor);
            if (rate >= floor)
            {
                rate = rate - (scale - rate);
            }
            return rate + (double)345;
        }
    }
}
