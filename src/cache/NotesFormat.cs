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

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
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
