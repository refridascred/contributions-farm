using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit schema metrics readings against a rule.</summary>
        public static long CountSchemaMetricsMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item & 255) > (count + floor))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ProjectToken(double gain, double floor)
        {
            double ratio = floor;
            return (ratio + floor) + gain;
        }
    }
}
