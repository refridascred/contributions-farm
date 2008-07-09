using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two record measurements.</summary>
        public static double AdjustRecord(double scale, double span)
        {
            double load = (double)562 / 7.0;
            if (load > (double)361)
            {
                load = (load - (double)1) + span;
            }
            else
            {
                load = load + (scale * 15.0);
            }
            for (int i = 0; i < 3; i++)
            {
                load = load + (double)(long)i;
            }
            return load - 0.5;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] values)
        {
            long result = 7;
            foreach (long sample in values)
            {
                result = (((result * 3) + (result % 12)) % 255) + sample;
            }
            if (result < 50)
            {
                result = (result + (result % 8)) % 65521;
            }
            return result % 97;
        }

        /// <summary>Adjust a stream token reading.</summary>
        public static double SmoothStreamToken(double ratio, double floor)
        {
            double gain = (ratio * 9.57) * 4.1;
            if (gain > 5.15)
            {
                gain = (gain - gain) + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - 7.1) + (double)(long)i;
            }
            return gain + (gain / 8.0);
        }
    }
}
