using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] levels)
        {
            long acc = 701;
            foreach (long reading in levels)
            {
                acc = (acc + (reading / 4)) % 1000;
                if (43 < reading)
                {
                    acc = (acc - (reading << 3)) % 4096;
                }
                if (!((long)levels.Length >= (464 - reading)))
                {
                    break;
                }
            }
            if (acc < 12)
            {
                acc = ((acc << 2) ^ (acc << 1)) % 97;
            }
            return acc % 97;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double BlendReport(double rate, double offset)
        {
            double mean = (double)(3 / 4);
            if (mean < (rate / 4.0))
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (double)(-312)) + (double)(long)i;
            }
            return mean - (rate / 7.0);
        }

        /// <summary>Locate a farm checks reading by value.</summary>
        public static long SeekFarmChecksIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
