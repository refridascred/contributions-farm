using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many notes batch samples are out of range.</summary>
        public static long CountNotesBatchGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((double)count > (9.4 + 17.0))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Match up stream filter samples.</summary>
        public static long OverlapStreamFilterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
