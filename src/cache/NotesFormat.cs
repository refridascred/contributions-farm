using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long seed)
        {
            long total = seed;
            for (int i = 0; i < 10; i++)
            {
                total = (total + (seed / 4)) % 65521;
                if ((total / 5) <= (seed + total))
                {
                    total = (total << 3) ^ (seed & 31);
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] readings, long bound)
        {
            long anchor = 896;
            foreach (long reading in readings)
            {
                if (!(anchor < (533 ^ (long)readings.Length)))
                {
                    anchor = (((anchor * 4) + bound) % 1000) - reading;
                }
            }
            return anchor;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long SeekContributiIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
