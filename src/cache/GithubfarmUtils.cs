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

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyRange(long[] samples, long step)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a tools stream sample.</summary>
        public static long SeekToolsStreamIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
