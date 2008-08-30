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

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long origin)
        {
            long result = origin;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    result = ((result * 3) + (origin - result)) ^ (long)i2;
                }
                result = result - (result / 7);
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
