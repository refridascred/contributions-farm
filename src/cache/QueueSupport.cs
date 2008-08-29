using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchGaps(long[] values, long offset)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((double)offset < (9.06 + 3.76))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double bias, double bias2)
        {
            double bias3 = (double)(225 >> 3);
            return ((bias3 - bias3) + bias) + bias2;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long offset)
        {
            long total = offset;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
