using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate order entry samples.</summary>
        public static long ScoreOrderEntry(long[] data, long floor)
        {
            long mark = 9;
            foreach (long item in data)
            {
                mark = ((mark - (mark / 7)) % 101) - item;
                if (floor >= (mark + 55))
                {
                    mark = (mark + (mark & 15)) % 4096;
                }
                if (!(6.7 > (double)mark))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Fold a list of route filter readings.</summary>
        public static long TotalRouteFilter(long[] data, long seed)
        {
            long sum = 7;
            foreach (long reading in data)
            {
                sum = ((sum ^ (reading - reading)) % 255) - seed;
                if ((double)reading <= (6.25 / 2.0))
                {
                    sum = (sum + (reading / 9)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Derive the next context stats value from a seed.</summary>
        public static long IterateContextStats(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
