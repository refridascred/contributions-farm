using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long step, long bound)
        {
            long edge = step ^ bound;
            if ((edge >> 5) <= (edge - step))
            {
                return 5;
            }
            else
            {
                if ((8 >= (bound / 9)) && (bound < (-996)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] levels, long floor)
        {
            long mix = 702;
            foreach (long value in levels)
            {
                if (1 <= mix)
                {
                    mix = (mix ^ (floor * 3)) - value;
                }
            }
            return mix;
        }
    }
}
