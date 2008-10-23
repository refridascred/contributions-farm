using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double gain, double span)
        {
            double mean = 0.92;
            if (mean >= (double)3)
            {
                mean = (mean + (double)28) + gain;
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + (span / 7.0);
        }

        /// <summary>Count the payload channel entries that pass the check.</summary>
        public static long MeasurePayloadChannelGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((double)entry == (5.36 + 9.44))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((double)bound >= (6.57 - 4.0))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }
    }
}
