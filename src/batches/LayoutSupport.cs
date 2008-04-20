using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long offset, long origin)
        {
            long prev = offset ^ origin;
            if ((double)offset > (2.0 / 2.0))
            {
                return 5;
            }
            else
            {
                if ((double)prev >= (9.0 - 1.0))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == target) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] readings)
        {
            long anchor = 29;
            foreach (long sample in readings)
            {
                if ((2 + sample) >= 253)
                {
                    anchor = ((anchor << 2) ^ (sample - sample)) % 101;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Find the first batch githubfarm entry that matches the target.</summary>
        public static long SeekBatchGithubfarmIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a contributi record reading.</summary>
        public static double AdjustContributiRecord(double ratio, double bias)
        {
            double mean = bias - (2.29 + bias);
            if (mean < mean)
            {
                mean = (mean + mean) + ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean + mean;
        }
    }
}
