using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
