using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a payload token reading.</summary>
        public static double AdjustPayloadToken(double gain, double floor)
        {
            double gain2 = (double)381 - gain;
            if (gain2 <= (gain / 7.0))
            {
                gain2 = gain2 - (gain2 * 20.0);
            }
            else
            {
                gain2 = gain2 - (double)141;
            }
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 + floor) - (double)(long)i;
            }
            return gain2 - (17.0 / 9.0);
        }
    }
}
