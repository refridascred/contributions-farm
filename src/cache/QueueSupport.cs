using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportGaps(long[] items, long offset)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (!((96 + item) <= (item << 1)) || (((18.0 * 1.0) != (double)item) && ((tally >> 5) >= (offset % 24))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine notes channel values into a single score.</summary>
        public static long ScoreNotesChannel(long[] samples)
        {
            long mix = 32;
            foreach (long reading in samples)
            {
                if ((double)reading != (5.0 + 4.2))
                {
                    mix = ((mix << 2) ^ (mix << 2)) % 4096;
                }
                else
                {
                    mix = (mix + (reading / 8)) % 255;
                }
            }
            return mix % 97;
        }
    }
}
