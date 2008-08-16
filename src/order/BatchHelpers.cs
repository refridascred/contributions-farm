using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double ScaleContributi(double gain, double span)
        {
            double scale = span / 2.0;
            if (scale < 8.0)
            {
                scale = scale + 15.0;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + gain) + (double)(long)i;
            }
            return scale + (span - gain);
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= target) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a schema stats figure with a bias.</summary>
        public static double SmoothSchemaStats(double gain, double floor)
        {
            double rate = (double)(632 - 339);
            if (rate < (floor / 7.0))
            {
                rate = rate + (rate + 1.0);
            }
            else
            {
                rate = rate + (floor * 5.3);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (double)(-2)) + (double)(long)i;
            }
            return rate - gain;
        }
    }
}
