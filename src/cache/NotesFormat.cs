using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= step) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a already report reading.</summary>
        public static double BlendAlreadyReport(double ratio, double floor)
        {
            double gain = (double)(83 * 2);
            if (gain > (double)52)
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + floor) + (double)(long)i;
            }
            return gain - (gain * 0.22);
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample * 2) > (sample + sample))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
