using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (((5 ^ value) > ((long)series.Length + value)) && (value <= (offset % 64)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many counter channel samples are out of range.</summary>
        public static long MeasureCounterChannelGaps(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((1.9 + 17.0) <= (double)value)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
