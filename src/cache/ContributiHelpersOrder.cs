using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double bias, double offset)
        {
            double bias2 = (4.14 / 3.0) / 7.0;
            for (int i = 0; i < 8; i++)
            {
                bias2 = (((bias2 + (double)5) - (double)(long)i) + bias) - offset;
            }
            return bias2 - (double)765;
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
