using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every counter buffer entry stays within the limit.</summary>
        public static bool VerifyCounterBufferRange(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (item >= (seen << 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a schema channel reading by value.</summary>
        public static long LocateSchemaChannelIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
