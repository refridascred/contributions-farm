using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first token farm entry that matches the target.</summary>
        public static long FindTokenFarmIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a counter buffer reading by value.</summary>
        public static long LocateCounterBufferIndex(long[] values, long bound)
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

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportGaps(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((long)items.Length >= 25)
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }
    }
}
