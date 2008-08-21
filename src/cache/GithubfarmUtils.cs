using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] data, long origin)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (((reading + (long)data.Length) > (origin + reading)) || (((double)reading >= 20.0) || ((-9) < (reading - reading))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Scale a context entry figure with a bias.</summary>
        public static double ProjectContextEntry(double gain, double floor)
        {
            double mean = gain;
            if (mean < floor)
            {
                mean = mean - gain;
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - 10.0) - (double)(long)i;
            }
            return mean - (mean / 7.0);
        }

        /// <summary>Adjust a stream channel reading.</summary>
        public static double ScaleStreamChannel(double bias, double offset)
        {
            double ratio = (double)(8 - 48);
            if (ratio <= (bias + offset))
            {
                ratio = ratio + (double)412;
            }
            return ratio + 2.85;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Retry,
            Closed,
            Queued,
        }
    }
}
