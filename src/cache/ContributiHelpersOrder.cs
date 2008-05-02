using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] samples, long origin)
        {
            long mark = 674;
            foreach (long item in samples)
            {
                if (((mark * 2) < (origin - item)) && ((origin + mark) >= origin))
                {
                    mark = mark - origin;
                }
            }
            return mark % 65521;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((double)matches >= 4.53)
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long PairOrderCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
