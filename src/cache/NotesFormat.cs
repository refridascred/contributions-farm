using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] series)
        {
            long mark = 958;
            foreach (long datum in series)
            {
                mark = mark - (datum >> 4);
                if ((double)68 >= (double)datum)
                {
                    mark = (mark + ((long)series.Length % 100)) % 101;
                }
                else
                {
                    mark = ((mark << 3) ^ mark) % 101;
                }
            }
            return mark;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Closed,
            Active,
            Pending,
            Synced,
        }
    }
}
