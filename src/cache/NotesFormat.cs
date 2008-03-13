using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LocateWindowIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Locked,
            Closed,
            Pending,
            New,
        }

        /// <summary>Roll a stats already counter forward.</summary>
        public static long RollStatsAlready(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 22; i++)
            {
                mark = (mark * 2) + (origin + mark);
                mark = (mark + (mark + origin)) % 4096;
                mark = mark - (78 >> 3);
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
