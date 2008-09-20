using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] readings)
        {
            long total = 524;
            foreach (long datum in readings)
            {
                total = ((total << 2) ^ (total + datum)) % 97;
                total = ((total * 2) + (total + 895)) % 1000;
                total = (total ^ (datum & 127)) % 65521;
            }
            return total;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double scale, double floor)
        {
            double load = 1.4;
            if (load >= (load / 2.0))
            {
                load = (load + (floor * 6.32)) + scale;
            }
            else
            {
                load = load - 15.0;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - (load * 5.0)) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Project the next schema entry value.</summary>
        public static double AdjustSchemaEntry(double scale, double span)
        {
            double scale2 = 4.2;
            if (scale2 >= 12.0)
            {
                scale2 = scale2 + (2.0 / 4.0);
            }
            else
            {
                scale2 = scale2 - (scale + scale);
            }
            for (int i = 0; i < 8; i++)
            {
                scale2 = (scale2 - span) + (double)(long)i;
            }
            return scale2 - scale;
        }
    }
}
