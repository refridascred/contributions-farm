using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 4379;
        public const long StepSize = 1482;
        public const string SoftNotes = "open-v2";

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] data)
        {
            long sum = 5;
            foreach (long reading in data)
            {
                if ((10.0 * 13.0) < (double)reading)
                {
                    sum = sum ^ (reading + reading);
                }
                else
                {
                    sum = (sum ^ reading) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double bias, double bias2)
        {
            double scale = (double)(93 / 8);
            if (scale <= (scale / 5.0))
            {
                scale = ((scale - (double)7) + bias) - bias2;
            }
            return scale + scale;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double AdjustFilter(double weight, double offset)
        {
            double bias = (2.94 + weight) * 8.3;
            return (bias - (bias * 17.0)) + offset;
        }
    }
}
